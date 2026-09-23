using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Web-Development-services")]
    public class WebDevelopmentController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ServiceTitle"] = "Web Development";
            ViewData["ServiceDescription"] = "Design and build scalable websites, portals, and web applications for modern businesses.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/Web-Development-services/API%20Development", "API Development", "Create secure and scalable APIs." },
                new[] { "/Web-Development-services/Corporate%20Websites", "Corporate Websites", "Present your business with a high-quality website." },
                new[] { "/Web-Development-services/CRM%20Portal", "CRM Portals", "Connect customers and teams through portals." },
                new[] { "/Web-Development-services/Custom%20Web%20Applications", "Custom Web Applications", "Build web solutions around your workflows." },
                new[] { "/Web-Development-services/E%20Commerce", "E-Commerce", "Create effective online commerce experiences." },
                new[] { "/Web-Development-services/ERP", "ERP Solutions", "Connect business operations with web technology." },
                new[] { "/Web-Development-services/HRMS", "HRMS", "Simplify human resource management." },
                new[] { "/Web-Development-services/LMS", "LMS", "Deliver connected learning and training platforms." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
        }

        [HttpGet("Corporate Websites")]
        public IActionResult CorporateWebsites()
        {
            return View("~/Views/Services/Web Development/CorporateWebsites.cshtml");
        }

        [HttpGet("Custom Web Applications")]
        public IActionResult CustomWebApplications()
        {
            return View("~/Views/Services/Web Development/CustomWebApplications.cshtml");
        }

        [HttpGet("ERP")]
        public IActionResult ERP()
        {
            return View("~/Views/Services/Web Development/ERP.cshtml");
        }
        [HttpGet("CRM Portal")]
        public IActionResult CRMPortal()
        {
            return View("~/Views/Services/Web Development/CRMPortal.cshtml");
        }
        [HttpGet("HRMS")]
        public IActionResult HRMS()
        {
            return View("~/Views/Services/Web Development/HRMS.cshtml");
        }
        [HttpGet("LMS")]
        public IActionResult LMS()
        {
            return View("~/Views/Services/Web Development/LMS.cshtml");
        }

        [HttpGet("E Commerce")]
        public IActionResult ECommerce()
        {
            return View("~/Views/Services/Web Development/E-Commerce.cshtml");
        }

        [HttpGet("API Development")]
        public IActionResult APIDevelopment()
        {
            return View("~/Views/Services/Web Development/APIDevelopment.cshtml");
        }
    }
}