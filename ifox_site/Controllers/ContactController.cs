using ifox_site.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ifox_site.Controllers
{
    public class ContactController : Controller
    {
        //// GET: ContactController
        //public ActionResult SendEmail()
        //{
        //    return View();
        //}

        //// GET: ContactController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ContactController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ContactController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ContactController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ContactController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ContactController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ContactController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        private readonly ILogger<ContactController> _logger;

        public int Port { get; private set; }


        private ICompositeViewEngine _viewEngine;
        private IServiceProvider _serviceProvider;

        public ContactController(ICompositeViewEngine viewEngine, ILogger<ContactController> logger, IServiceProvider serviceProvider)
        {
            _viewEngine = viewEngine;
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public IActionResult EmailMessage()
        {

            return View();
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string SendEmail(SendMailViewModel sendMailView)
        {


            try
            {
                SendEmailToIfox(sendMailView);


                 SendEmailToContact(sendMailView);
            }

            catch (Exception ex)
            {
                ViewBag.Message = ex.Message.ToString();
                return "Not Sent : " + ex.Message;
            }


            return "Success";
        }

        public IActionResult BackToHome()
        {

            return View();
        }

        public void SendEmailToIfox(SendMailViewModel sendMailView)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("karthikpandi@ifox.co.in");
            mail.To.Add("info@ifox.co.in");
            mail.Subject = sendMailView.Name + " trying to reach out ifox";

            string content = RenderViewToString("EmailMessage", sendMailView);
            mail.IsBodyHtml = true;

            mail.Body = content;

            SmtpClient smtpClient = new SmtpClient("webmail.ifox.co.in");
            smtpClient.UseDefaultCredentials = false;
            NetworkCredential networkCredential = new NetworkCredential("karthikpandi@ifox.co.in", "karthik@2024$03");

            smtpClient.Credentials = networkCredential;
            smtpClient.Port = 25;
            smtpClient.EnableSsl = false;
            smtpClient.Send(mail);
            Thread.Sleep(4000);
            ViewBag.Message = "Mail Send";

            ModelState.Clear();

        }

        public void SendEmailToContact(SendMailViewModel sendMailView)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("karthikpandi@ifox.co.in");
            mail.To.Add(sendMailView.Email);
            mail.Subject = "Thank you for reaching out ifox.";

            mail.IsBodyHtml = true;
            string content = RenderViewToString("Thankyou", null);
            mail.Body = content;

            SmtpClient smtpClient = new SmtpClient("webmail.ifox.co.in");
            smtpClient.UseDefaultCredentials = false;
            NetworkCredential networkCredential = new NetworkCredential("karthikpandi@ifox.co.in", "karthik@2024$03");

            smtpClient.Credentials = networkCredential;
            smtpClient.Port = 25;
            smtpClient.EnableSsl = false;
            smtpClient.Send(mail);
            Thread.Sleep(4000);

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
