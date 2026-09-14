using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Strategy-Vision")]
    public class ProductStrategyVisionController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Product-Consulting")]
        public IActionResult ProductConsulting()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/ProductConsulting.cshtml");
        }

        [HttpGet("Product-Goals")]
        public IActionResult ProductGoals()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/ProductGoals.cshtml");
        }

        [HttpGet("Product-Portfolio")]
        public IActionResult ProductPortfolio()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/ProductPortfolio.cshtml");
        }

        [HttpGet("Product-Positioning")]
        public IActionResult Productpositioning()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/Productpositioning.cshtml");
        }

        [HttpGet("Product-Strategy")]
        public IActionResult ProductStrategy()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/ProductStrategy.cshtml");
        }

        [HttpGet("Product-Strategy-Vision")]
        public IActionResult ProductStrategyVision()
        {
            return View("~/Views/Productmanagement/ProductStrategyVision/ProductStrategyVision.cshtml");
        }
    }
}