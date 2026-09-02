using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Power Platform Developer")]
    public class PowerPlatformDeveloperController : Controller
    {
        [HttpGet("Dataverse Developer")]
        public IActionResult DataverseDeveloper()
        {
            return View();
        }

        [HttpGet("Hire Power Automate Developer")]
        public IActionResult HirePowerAutomateDeveloper()
        {
            return View();
        }

        [HttpGet("Hire Power BI Developer")]
        public IActionResult HirePowerBIDeveloper()
        {
            return View();
        }

        [HttpGet("Power Apps Developer")]
        public IActionResult PowerAppsDeveloper()
        {
            return View();
        }
    }
}