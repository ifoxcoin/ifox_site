using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Hire D365 Developers")]
    public class D365DevelopersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("CRM Developers")]
        public IActionResult DynamicsCRMDevelopers()
        {
            return View();
        }

        [HttpGet("D365 Puligin Developers")]
        public IActionResult DynamicsPluginDevelopers()
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