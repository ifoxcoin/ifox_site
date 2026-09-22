using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Launch")]
    public class ProductLaunchController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/ProductManagement/ProductLaunch/Index.cshtml");
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