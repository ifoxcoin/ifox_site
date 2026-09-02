using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("React & Node Developer")]
    public class ReactAndNodeDeveloperController : Controller
    {
        [HttpGet("Full Stack Developer")]
        public IActionResult FullStackDeveloper()
        {
            return View();
        }

        [HttpGet("MERN Developer")]
        public IActionResult MERNDeveloper()
        {
            return View();
        }

        [HttpGet("Node JS Developer")]
        public IActionResult NodeJSDeveloper()
        {
            return View();
        }

        [HttpGet("React Developer")]
        public IActionResult ReactDeveloper()
        {
            return View();
        }
    }
}