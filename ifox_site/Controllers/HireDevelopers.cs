using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("hire-developers")]
    public class HireDevelopersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/HireDevelopers/Index.cshtml");
        }

        [HttpGet("Hire-Dot-Net-Developer")]
        public IActionResult HireDotNetDeveloper()
        {
            return View("~/Views/HireDevelopers/HireDotNetDeveloper.cshtml");
        }

        [HttpGet("Dot-Net-Developer")]
        public IActionResult DotNetDeveloper()
        {
            return View("~/Views/HireDevelopers/DotNetDeveloper.cshtml");
        }

        [HttpGet("CRM-Developer")]
        public IActionResult CRMDeveloper()
        {
            return View("~/Views/HireDevelopers/CRMDeveloper.cshtml");
        }

        [HttpGet("PHP-Developer")]
        public IActionResult PHPDeveloper()
        {
            return View("~/Views/HireDevelopers/PHPDeveloper.cshtml");
        }

        [HttpGet("Mobile-App-Developer")]
        public IActionResult MobileAppDeveloper()
        {
            return View("~/Views/HireDevelopers/MobileAppDeveloper.cshtml");
        }
    }
}