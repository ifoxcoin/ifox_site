using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("PHP Developer")]
    public class PHPDeveloperController : Controller
    {
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
        public IActionResult PHPECommerceDeveloper()
        {
            return View();
        }

        [HttpGet("WordPress Developer")]
        public IActionResult WordPressDeveloper()
        {
            return View();
        }
    }
}