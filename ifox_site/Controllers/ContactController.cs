using ifox_site.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace ifox_site.Controllers
{
    [Route("contact-us")]
    [Route("contact")]
    public class ContactController : Controller
    {


        private readonly ILogger<ContactController> _logger;

        public int Port { get; private set; }


        private ICompositeViewEngine _viewEngine;
        private IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        public ContactController(ICompositeViewEngine viewEngine, ILogger<ContactController> logger, IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _viewEngine = viewEngine;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }

        [HttpGet("email-message")]
        public IActionResult EmailMessage()
        {

            return View();
        }

        [HttpGet("thankyou")]
        public IActionResult Thankyou()
        {

            return View();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> SendEmail(SendMailViewModel sendMailView, [FromForm(Name = "file")] IFormFile? file)
        {
            if (!ModelState.IsValid)
            {
                return "Please correct the highlighted fields and try again.";
            }

            if (file != null)
            {
                var allowedExtensions = new[] { ".pdf", ".doc", ".docx", ".xls", ".xlsx" };
                var extension = Path.GetExtension(file.FileName);
                if (file.Length > 5 * 1024 * 1024 || !allowedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase))
                {
                    return "Only PDF, Word, and Excel files up to 5 MB are allowed.";
                }
            }

            if (Request.Form["local-captcha"] == "verified")
            {
                try
                {
                    SendEmailToIfox(sendMailView, file);
                    SendEmailToContact(sendMailView);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Contact form email delivery failed.");
                    ViewBag.Message = "Unable to send your message right now.";
                    return "Not Sent : Unable to send your message right now.";
                }

                return "Success";
            }

            return "CAPTCHA verification failed. Please complete the CAPTCHA and try again.";
        }

        [HttpGet("back-to-home")]
        public IActionResult BackToHome()
        {

            return View();
        }

        private async Task<bool> VerifyCaptcha(string captchaResponse)
        {
            var secretKey = _configuration["Recaptcha:SecretKey"];
            if (string.IsNullOrWhiteSpace(secretKey) || string.IsNullOrWhiteSpace(captchaResponse))
            {
                _logger.LogWarning("reCAPTCHA verification was skipped because the secret key or response is missing.");
                return false;
            }

            using var httpClient = new HttpClient();
            using var verificationContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("secret", secretKey),
                new KeyValuePair<string, string>("response", captchaResponse),
                new KeyValuePair<string, string>("remoteip", HttpContext.Connection.RemoteIpAddress?.ToString() ?? string.Empty)
            });

            var response = await httpClient.PostAsync("https://www.google.com/recaptcha/api/siteverify", verificationContent);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var captchaResult = JsonConvert.DeserializeObject<CaptchaResponse>(jsonResponse);
                return captchaResult?.Success == true;
            }
            return false;
        }

        public class CaptchaResponse
        {
            [JsonProperty("success")]
            public bool Success { get; set; }
        }

        public void SendEmailToIfox(SendMailViewModel sendMailView, IFormFile? file)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_configuration["EmailSettings:FromEmail"] ?? "sales@ifox.co.in");
            mail.To.Add(_configuration["EmailSettings:ToEmail"] ?? "info@ifox.co.in");
            mail.Subject = sendMailView.Name + " trying to reach out ifox";
            mail.Priority = MailPriority.High;
            sendMailView.Attachments = file;
            if (sendMailView.Attachments != null)
            {
                string fileName = Path.GetFileName(sendMailView.Attachments.FileName);
                mail.Attachments.Add(new Attachment(sendMailView.Attachments.OpenReadStream(), fileName));
            }

            string content = RenderViewToString("EmailMessage", sendMailView);
            mail.IsBodyHtml = true;
            mail.Body = content;

            SmtpClient smtpClient = new SmtpClient(_configuration["ContactEmailSettings:SmtpServer"] ?? _configuration["EmailSettings:SmtpServer"]);
            smtpClient.UseDefaultCredentials = false;
            NetworkCredential networkCredential = new NetworkCredential(
                _configuration["ContactEmailSettings:Username"] ?? _configuration["EmailSettings:FromEmail"],
                _configuration["ContactEmailSettings:Password"] ?? _configuration["EmailSettings:AppPassword"]);
            smtpClient.Credentials = networkCredential;
            smtpClient.Port = int.Parse(_configuration["ContactEmailSettings:Port"] ?? _configuration["EmailSettings:Port"] ?? "587");
            smtpClient.EnableSsl = bool.Parse(_configuration["ContactEmailSettings:EnableSsl"] ?? "true");
            smtpClient.Send(mail);
            ViewBag.Message = "Mail Send";

            ModelState.Clear();

        }

        public void SendEmailToContact(SendMailViewModel sendMailView)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_configuration["EmailSettings:FromEmail"] ?? "info@ifox.co.in");
            mail.To.Add(sendMailView.Email);
            mail.Subject = "Thank you for reaching out ifox.";
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;
            string content = RenderViewToString("Thankyou", null);
            mail.Body = content;

            SmtpClient smtpClient = new SmtpClient(_configuration["ContactEmailSettings:SmtpServer"] ?? _configuration["EmailSettings:SmtpServer"]);
            smtpClient.UseDefaultCredentials = false;
            NetworkCredential networkCredential = new NetworkCredential(
                _configuration["ContactEmailSettings:Username"] ?? _configuration["EmailSettings:FromEmail"],
                _configuration["ContactEmailSettings:Password"] ?? _configuration["EmailSettings:AppPassword"]);

            smtpClient.Credentials = networkCredential;
            smtpClient.Port = int.Parse(_configuration["ContactEmailSettings:Port"] ?? _configuration["EmailSettings:Port"] ?? "587");
            smtpClient.EnableSsl = bool.Parse(_configuration["ContactEmailSettings:EnableSsl"] ?? "true");
            smtpClient.Send(mail);

            ModelState.Clear();

        }

        public string RenderViewToString(string viewName, object? model)
        {
            ViewData.Model = model;
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.ActionDescriptor.DisplayName;

            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = _viewEngine.FindView(ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    sw,
                    new HtmlHelperOptions() //Added this parameter in
                );

                //Everything is async now!
                var t = viewResult.View.RenderAsync(viewContext);
                t.Wait();

                return sw.GetStringBuilder().ToString();
            }
        }
    }
}