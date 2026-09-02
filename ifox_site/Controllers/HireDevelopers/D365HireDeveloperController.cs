using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("D365Developers")]
    public class D365HireDeveloperController : Controller
    {
        [HttpGet("CRM Developers")]
        public IActionResult CRMDevelopers()
        {
            return View();
        }

        [HttpGet("D365 Consultant")]
        public IActionResult D365Consultant()
        {
            return View();
        }

        [HttpGet("Dynamics CRM Developers")]
        public IActionResult DynamicsCRMDevelopers()
        {
            return View();
        }

        [HttpGet("Dynamics Plugin Developers")]
        public IActionResult DynamicsPluginDevelopers()
        {
            return View();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Power Platform")]
        public IActionResult PowerPlatform()
        {
            return View();
        }
    }
}