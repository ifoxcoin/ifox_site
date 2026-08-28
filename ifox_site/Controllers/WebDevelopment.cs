using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Web-Development-services")]
    public class Web_Development : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Corporate Websites")]
        public IActionResult CorporateWebsites()
        {
            return View();
        }

        [HttpGet("Custom Web Applications")]
        public IActionResult CustomWebApplications()
        {
            return View();
        }

        [HttpGet("ERP")]
        public IActionResult ERP()
        {
            return View();
        }
        [HttpGet("CRM Portal")]
        public IActionResult CRMPortal()
        {
            return View();
        }
        [HttpGet("HRMS")]
        public IActionResult HRMS()
        {
            return View();
        }
        [HttpGet("LMS")]
        public IActionResult LMS()
        {
            return View();
        }

        [HttpGet("E-Commerce")]
        public IActionResult ECommerce()
        {
            return View();
        }
    }
}