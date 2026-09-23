using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Power-Platform-Developer")]
    public class powerplatformDeveloperController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = "Power Platform Developers";
            ViewData["HireDescription"] = "Hire Power Platform specialists to connect data, automate work, and deliver business apps faster.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/Power-Platform-Developer/Dataverse-Developer", "Dataverse Developers", "Build secure data foundations" },
                new[] { "/Power-Platform-Developer/Hire-Power-Automate-Developer", "Power Automate Developers", "Automate business processes" },
                new[] { "/Power-Platform-Developer/Hire-Power-BI-Developer", "Power BI Developers", "Turn business data into insights" },
                new[] { "/Power-Platform-Developer/Power-Apps-Developer", "Power Apps Developers", "Create connected business applications" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
        }

        [HttpGet("Dataverse-Developer")]
        public IActionResult DataverseDeveloper()
        {
            return View("~/Views/HireDevelopers/Power Platform Developer/DataverseDeveloper.cshtml");
        }

        [HttpGet("Hire-Power-Automate-Developer")]
        public IActionResult HirePowerAutomateDeveloper()
        {
            return View("~/Views/HireDevelopers/Power Platform Developer/HirePowerAutomateDeveloper.cshtml");
        }

        [HttpGet("Hire-Power-BI-Developer")]
        public IActionResult HirePowerBIDeveloper()
        {
            return View("~/Views/HireDevelopers/Power Platform Developer/HirePowerBIDeveloper.cshtml");
        }

        [HttpGet("Power-Apps-Developer")]
        public IActionResult PowerAppsDeveloper()
        {
            return View("~/Views/HireDevelopers/Power Platform Developer/PowerAppsDeveloper.cshtml");
        }
    }
}