using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Power Platform Developer")]
    public class Power_Platform_Developer : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Dataverse Developer")]
        public IActionResult DataverseDeveloper()
        {
            return View();
        }

        [HttpGet("Power Apps Developer")]
        public IActionResult PowerAppsDeveloper()
        {
            return View();
        }

        [HttpGet("Power Automate Developer")]
        public IActionResult PowerAutomateDeveloper()
        {
            return View();
        }
        [HttpGet("Power BI Developer")]
        public IActionResult PowerBiDeveloper()
        {
            return View();
        }
    }
}