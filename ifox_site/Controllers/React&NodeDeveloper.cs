using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("React & Node Developer")]
    public class React_Node_Developer : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Full Stack Developer")]
        public IActionResult FullStackDeveloper()
        {
            return View();
        }

        [HttpGet("MERN Developer")]
        public IActionResult MernDeveloper()
        {
            return View();
        }

        [HttpGet("NodeJS Developer")]
        public IActionResult NodeJsDeveloper()
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