using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Power-Platform-Developer")]
    public class powerplatformDeveloperController : Controller
    {
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