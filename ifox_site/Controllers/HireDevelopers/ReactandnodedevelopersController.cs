using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Reactandnodedevelopers")]
    public class ReactandnodedevelopersController : Controller
    {
        [HttpGet("FullStackDeveloper")]
        public IActionResult FullStackDeveloper()
        {
            return View("~/Views/HireDevelopers/ReactAndNodeDeveloper/FullStackDeveloper.cshtml");
        }

        [HttpGet("MERNDeveloper")]
        public IActionResult MERNDeveloper()
        {
            return View("~/Views/HireDevelopers/ReactAndNodeDeveloper/MERNDeveloper.cshtml");
        }

        [HttpGet("NodeJsDeveloper")]
        public IActionResult NodeJsDeveloper()
        {
            return View("~/Views/HireDevelopers/ReactAndNodeDeveloper/NodeJsDeveloper.cshtml");
        }

        [HttpGet("ReactDeveloper")]
        public IActionResult ReactDeveloper()
        {
            return View("~/Views/HireDevelopers/ReactAndNodeDeveloper/ReactDeveloper.cshtml");
        }
    }
}