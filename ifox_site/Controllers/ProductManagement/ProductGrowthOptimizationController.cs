using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Growth-Optimization")]
    public class ProductGrowthOptimizationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Product Growth Optimization";
            ViewData["ProductDescription"] = "Improve adoption, conversion, retention, and product performance through continuous learning and optimization.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Product-Growth-Optimization/Conversion-Optimization", "Conversion Optimization", "Improve the journeys that turn interest into action." },
                new[] { "/Product-Growth-Optimization/Product-Analytics", "Product Analytics", "Use product data to understand behavior and performance." },
                new[] { "/Product-Growth-Optimization/Product-Growth", "Product Growth", "Create sustainable growth through focused product improvements." },
                new[] { "/Product-Growth-Optimization/Product-Growt-hOptimization", "Product Growth Optimization", "Identify and test opportunities across the product journey." },
                new[] { "/Product-Growth-Optimization/Retention-Optimization", "Retention Optimization", "Build experiences that keep customers engaged and successful." },
                new[] { "/Product-Growth-Optimization/User-Adoption", "User Adoption", "Help users discover, understand, and consistently use product value." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
        }

        [HttpGet("Conversion-Optimization")]
        public IActionResult ConversionOptimization()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/ConversionOptimization.cshtml");
        }

        [HttpGet("Product-Analytics")]
        public IActionResult ProductAnalytics()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/ProductAnalytics.cshtml");
        }

        [HttpGet("Product-Growth")]
        public IActionResult ProductGrowth()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/ProductGrowth.cshtml");
        }

        [HttpGet("Product-Growt-hOptimization")]
        public IActionResult ProductGrowthOptimization()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/ProductGrowthOptimization.cshtml");
        }

        [HttpGet("Retention-Optimization")]
        public IActionResult RetentionOptimization()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/RetentionOptimization.cshtml");
        }

        [HttpGet("User-Adoption")]
        public IActionResult UserAdoption()
        {
            return View("~/Views/Productmanagement/ProductGrowthOptimization/UserAdoption.cshtml");
        }
    }
}