using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("D365-Developers")]
    public class D365HireDeveloperController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/HireDevelopers/D365Developers/Index.cshtml");
        }

        [HttpGet("CRM-Developer")]
        public IActionResult CRMDevelopers()
        {
            return View("~/Views/HireDevelopers/D365Developers/CRMDevelopers.cshtml");
        }

        [HttpGet("D365-Consultant")]
        public IActionResult D365Consultant()
        {
            return View("~/Views/HireDevelopers/D365Developers/D365Consultant.cshtml");
        }

        [HttpGet("Dynamics-CRM-Developers")]
        public IActionResult DynamicsCRMDevelopers()
        {
            return View("~/Views/HireDevelopers/D365Developers/DynamicsCRMDevelopers.cshtml");
        }

        [HttpGet("Dynamics-Plugin-Developers")]
        public IActionResult DynamicsPluginDevelopers()
        {
            return View("~/Views/HireDevelopers/D365Developers/DynamicsPluginDevelopers.cshtml");
        }

        [HttpGet("Power-Platform")]
        public IActionResult PowerPlatform()
        {
            return View("~/Views/HireDevelopers/D365Developers/PowerPlatform.cshtml");
        }
    }
}