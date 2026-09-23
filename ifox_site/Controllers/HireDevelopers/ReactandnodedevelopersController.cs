using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Reactandnodedevelopers")]
    public class ReactandnodedevelopersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = "React & Node.js Developers";
            ViewData["HireDescription"] = "Hire modern JavaScript specialists to build fast, scalable, and engaging web applications.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/Reactandnodedevelopers/FullStackDeveloper", "Full Stack Developers", "Build complete modern web solutions" },
                new[] { "/Reactandnodedevelopers/MERNDeveloper", "MERN Developers", "Develop full-stack JavaScript applications" },
                new[] { "/Reactandnodedevelopers/NodeJsDeveloper", "Node.js Developers", "Create scalable server-side applications" },
                new[] { "/Reactandnodedevelopers/ReactDeveloper", "React Developers", "Build responsive user interfaces" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
        }

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