using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("PHP-Developer")]
    public class PhpDeveloperController : Controller
    {
        [HttpGet("Laravel-Developer")]
        public IActionResult LaravelDeveloper()
        {
            return View("~/Views/HireDevelopers/PHP Developer/LaravelDeveloper.cshtml");
        }

        [HttpGet("PHP-Developer")]
        public IActionResult PHPDeveloper()
        {
            return View("~/Views/HireDevelopers/PHP Developer/PHPDeveloper.cshtml");
        }

        [HttpGet("PHP-E-Commerce-Developer")]
        public IActionResult PHPECommerceDeveloper()
        {
            return View("~/Views/HireDevelopers/PHP Developer/PHPE-CommerceDeveloper.cshtml");
        }

        [HttpGet("WordPress-Developer")]
        public IActionResult WordPressDeveloper()
        {
            return View("~/Views/HireDevelopers/PHP Developer/WordPressDeveloper.cshtml");
        }
    }
}