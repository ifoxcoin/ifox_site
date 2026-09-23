using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Dot-Net-Developers")]
    public class DotNetDevelopersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = ".NET Developers";
            ViewData["HireDescription"] = "Hire skilled .NET developers to build secure, scalable web applications and APIs.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/Dot-Net-Developers/ASP-NET-Core-Developer", "ASP.NET Core Developers", "Build modern cross-platform applications" },
                new[] { "/Dot-Net-Developers/ASP-NET-Developer", "ASP.NET Developers", "Develop robust enterprise web solutions" },
                new[] { "/Dot-Net-Developers/Dot-Net-API-Developer", ".NET API Developers", "Create secure and scalable APIs" },
                new[] { "/Dot-Net-Developers/Dot-Net-Full-Stack-Developer", ".NET Full Stack Developers", "Deliver complete end-to-end applications" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
        }

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