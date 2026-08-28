using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("PHP Developer")]
    public class PHP_Developer : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Laravel Developer")]
        public IActionResult LaravelDeveloper()
        {
            return View();
        }

        [HttpGet("PHP Developer")]
        public IActionResult PHPDeveloper()
        {
            return View();
        }

        [HttpGet("PHP E-Commerce Developer")]
        public IActionResult PHPEcommerceDeveloper()
        {
            return View();
        }
        [HttpGet("Word Press Developer")]
        public IActionResult WordPressDeveloper()
        {
            return View();
        }
    }
}