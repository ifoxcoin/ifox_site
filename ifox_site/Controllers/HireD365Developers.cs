using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Hire D365 Developers")]
    public class Hire_D365_Developers : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("CRM Developers")]
        public IActionResult CRMDevelopers()
        {
            return View();
        }

        [HttpGet("D365 Puligin Developers")]
        public IActionResult D365PluginDevelopers()
        {
            return View();
        }

        [HttpGet("D365 Conslutant")]
        public IActionResult D365Conslutant()
        {
            return View();
        }

        [HttpGet("Power platform")]
        public IActionResult PowerPlatform()
        {
            return View();
        }
    }
}