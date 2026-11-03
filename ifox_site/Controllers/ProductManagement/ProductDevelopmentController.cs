using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Development")]
    public class ProductDevelopmentController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Product Development";
            ViewData["ProductDescription"] = "Build, test, and refine valuable products through a focused and collaborative development process.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Product-Development/Feature-Development", "Feature Development", "Turn validated opportunities into useful product features." },
                new[] { "/Product-Development/MVP-Development", "MVP Development", "Launch a focused first version and learn from real users." },
                new[] { "/Product-Development/Product-Design", "Product Design", "Create clear, accessible, and engaging product experiences." },
                new[] { "/Product-Development/Product-Development", "Product Development", "Coordinate product planning, delivery, testing, and improvement." },
                new[] { "/Product-Development/Product-Development-Launch", "Product Development Launch", "Prepare teams, customers, and systems for a successful launch." },
                new[] { "/Product-Development/Product-Engineering", "Product Engineering", "Build reliable technical foundations that support product growth." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
        }

        [HttpGet("Feature-Development")]
        public IActionResult FeatureDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/FeatureDevelopment.cshtml");
        }

        [HttpGet("MVP-Development")]
        public IActionResult MVPDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/MVPDevelopment.cshtml");
        }

        [HttpGet("Product-Design")]
        public IActionResult ProductDesign()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDesign.cshtml");
        }

        [HttpGet("Product-Development")]
        public IActionResult ProductDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDevelopment.cshtml");
        }

        [HttpGet("Product-Development-Launch")]
        public IActionResult ProductDevelopmentLaunch()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDevelopmentLaunch.cshtml");
        }

        [HttpGet("Product-Engineering")]
        public IActionResult ProductEngineering()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductEngineering.cshtml");
        }
    }
}