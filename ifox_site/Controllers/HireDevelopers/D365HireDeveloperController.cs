using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("D365-Developers")]
    public class D365HireDeveloperController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = "Dynamics 365 Developers";
            ViewData["HireDescription"] = "Hire experienced Dynamics 365 CRM and Power Platform developers for scalable business solutions.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/D365-Developers/CRM-Developer", "CRM Developers", "Build and customize Dynamics CRM solutions" },
                new[] { "/D365-Developers/D365-Consultant", "D365 Consultants", "Plan and optimize Dynamics 365 implementations" },
                new[] { "/D365-Developers/Dynamics-CRM-Developers", "Dynamics CRM Developers", "Develop connected customer experiences" },
                new[] { "/D365-Developers/Dynamics-Plugin-Developers", "Dynamics Plugin Developers", "Extend CRM with reliable plugins" },
                new[] { "/D365-Developers/Power-Platform", "Power Platform Developers", "Create apps and automations with Power Platform" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
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