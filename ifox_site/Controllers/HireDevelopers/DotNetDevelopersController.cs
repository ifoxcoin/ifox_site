using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Dot-Net-Developers")]
    public class DotNetDevelopersController : Controller
    {
        [HttpGet("ASP-NET-Core-Developer")]
        public IActionResult ASPNETCoreDeveloper()
        {
            return View("~/Views/HireDevelopers/NETDeveloper/ASPNETCoreDeveloper.cshtml");
        }

        [HttpGet("ASP-NET-Developer")]
        public IActionResult ASPNETDeveloper()
        {
            return View("~/Views/HireDevelopers/NETDeveloper/ASPNETDeveloper.cshtml");
        }

        [HttpGet("Dot-Net-API-Developer")]
        public IActionResult DotNetAPIDeveloper()
        {
            return View("~/Views/HireDevelopers/NETDeveloper/DotNetAPIDeveloper.cshtml");
        }

        [HttpGet("Dot-Net-Full-Stack-Developer")]
        public IActionResult DotNetFullStackDeveloper()
        {
            return View("~/Views/HireDevelopers/NETDeveloper/DotNetFullStackDeveloper.cshtml");
        }
    }
}