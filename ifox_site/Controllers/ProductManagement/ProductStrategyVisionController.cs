using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Strategy-Vision")]
    public class ProductStrategyVisionController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Product Strategy & Vision";
            ViewData["ProductDescription"] = "Define a compelling product vision and strategy that guides decisions, teams, and long-term growth.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Product-Strategy-Vision/Product-Consulting", "Product Consulting", "Get experienced guidance for complex product decisions." },
                new[] { "/Product-Strategy-Vision/Product-Goals", "Product Goals", "Translate business ambition into clear product outcomes." },
                new[] { "/Product-Strategy-Vision/Product-Portfolio", "Product Portfolio", "Balance products, investments, opportunities, and lifecycle priorities." },
                new[] { "/Product-Strategy-Vision/Product-Positioning", "Product Positioning", "Clarify how your product creates value in the market." },
                new[] { "/Product-Strategy-Vision/Product-Strategy", "Product Strategy", "Connect market insight, customer value, and business direction." },
                new[] { "/Product-Strategy-Vision/Product-Strategy-Vision", "Product Strategy Vision", "Create a shared vision that keeps teams moving together." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
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