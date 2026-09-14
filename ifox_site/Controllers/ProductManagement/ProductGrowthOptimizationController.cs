using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Growth-Optimization")]
    public class ProductGrowthOptimizationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
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