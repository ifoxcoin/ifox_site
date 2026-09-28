using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;

namespace ifox_site.Controllers
{
    [Route("newsletter")]
    public class NewsletterController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<NewsletterController> _logger;

        public NewsletterController(IConfiguration configuration, ILogger<NewsletterController> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        [HttpPost("subscribe")]
        [ValidateAntiForgeryToken]
        public IActionResult Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email))
            {
                TempData["NewsletterError"] = "Please enter a valid email address.";
                return RedirectToReferer();
            }

            try
            {
                using var message = new MailMessage
                {
                    From = new MailAddress(_configuration["EmailSettings:FromEmail"] ?? "sales@ifox.co.in"),
                    Subject = "New newsletter subscription",
                    Body = $"A new visitor subscribed to the iFOX newsletter: {email}",
                    IsBodyHtml = false
                };
                message.To.Add(_configuration["EmailSettings:ToEmail"] ?? "info@ifox.co.in");

                using var smtpClient = new SmtpClient(_configuration["EmailSettings:SmtpServer"])
                {
                    Port = int.TryParse(_configuration["EmailSettings:Port"], out var port) ? port : 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(
                        _configuration["EmailSettings:FromEmail"],
                        _configuration["EmailSettings:AppPassword"])
                };

                smtpClient.Send(message);
                TempData["NewsletterSuccess"] = "Thank you for subscribing to our newsletter.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Newsletter subscription email delivery failed.");
                TempData["NewsletterError"] = "We could not complete your subscription right now. Please try again later.";
            }

            return RedirectToReferer();
        }

        private IActionResult RedirectToReferer()
        {
            var referer = Request.Headers["Referer"].ToString();
            Uri uri;
            if (!string.IsNullOrWhiteSpace(referer)
                && Uri.TryCreate(referer, UriKind.Absolute, out uri)
                && uri.Host == Request.Host.Host)
            {
                return Redirect(uri.PathAndQuery + "#newsletter");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}