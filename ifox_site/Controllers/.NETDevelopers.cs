using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("DOT-NET Developers")]
    public class Dot_NET_Developers : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("ASP.NET Core Developers ")]
        public IActionResult ASPDotNetCoreDevelopers()
        {
            return View();
        }

        [HttpGet("ASPDotNetDevelopers")]
        public IActionResult ASPDotNetDevelopers()
        {
            return View();
        }

        [HttpGet("ASP DOT-NET API Developers")]
        public IActionResult ASPDotNetApiDevelopers()
        {
            return View();
        }
        [HttpGet("DOT-NET FullStack Developer")]
        public IActionResult DotNetFukllstack()
        {
            return View();
        }
    }
}