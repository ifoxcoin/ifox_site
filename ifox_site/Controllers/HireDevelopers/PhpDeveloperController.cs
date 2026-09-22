using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("PHP-Developer")]
    public class PhpDeveloperController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = "PHP Developers";
            ViewData["HireDescription"] = "Hire PHP developers to deliver flexible, secure, and scalable web applications.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/PHP-Developer/Laravel-Developer", "Laravel Developers", "Build modern Laravel applications" },
                new[] { "/PHP-Developer/PHP-Developer", "PHP Developers", "Develop dependable PHP solutions" },
                new[] { "/PHP-Developer/PHP-E-Commerce-Developer", "PHP E-Commerce Developers", "Create effective online commerce platforms" },
                new[] { "/PHP-Developer/WordPress-Developer", "WordPress Developers", "Build and customize WordPress websites" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
        }

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