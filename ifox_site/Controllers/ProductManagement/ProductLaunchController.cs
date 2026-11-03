using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Launch")]
    public class ProductLaunchController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Product Launch";
            ViewData["ProductDescription"] = "Plan and deliver product launches that align teams, reach the right audience, and create momentum.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Product-Launch/Go-To-Market-Strategy", "Go-To-Market Strategy", "Define the audience, positioning, channels, and launch plan." },
                new[] { "/Product-Launch/Launch-Management", "Launch Management", "Coordinate launch activities, teams, dependencies, and timelines." },
                new[] { "/Product-Launch/Launch-Optimization", "Launch Optimization", "Learn from launch performance and improve the next opportunity." },
                new[] { "/Product-Launch/Product-Launch-planning", "Product Launch Planning", "Prepare the product, organization, and customers for release." },
                new[] { "/Product-Launch/Product-Marketing", "Product Marketing", "Communicate product value clearly to the right market." },
                new[] { "/Product-Launch/Release-Planning", "Release Planning", "Plan reliable releases with clear scope, readiness, and communication." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
        }

        [HttpGet("Go-To-Market-Strategy")]
        public IActionResult GoTomarketStrategy()
        {
            return View("~/Views/Productmanagement/ProductLaunch/GoToMarketStrategy.cshtml");
        }

        [HttpGet("Launch-Management")]
        public IActionResult LaunchManagement()
        {
            return View("~/Views/Productmanagement/ProductLaunch/LaunchManagement.cshtml");
        }

        [HttpGet("Launch-Optimization")]
        public IActionResult LaunchOptimization()
        {
            return View("~/Views/Productmanagement/ProductLaunch/LaunchOptimization.cshtml");
        }

        [HttpGet("Product-Launch-planning")]
        public IActionResult ProductLaunchplanning()
        {
            return View("~/Views/Productmanagement/ProductLaunch/ProductLaunchplanning.cshtml");
        }

        [HttpGet("Product-Marketing")]
        public IActionResult ProductMarketing()
        {
            return View("~/Views/Productmanagement/ProductLaunch/ProductMarketing.cshtml");
        }

        [HttpGet("Release-Planning")]
        public IActionResult ReleasePlanning()
        {
            return View("~/Views/Productmanagement/ProductLaunch/ReleasePlanning.cshtml");
        }
    }
}