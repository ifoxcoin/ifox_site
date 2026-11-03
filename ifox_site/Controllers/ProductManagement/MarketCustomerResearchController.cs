using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Market-Customer-Research")]
    public class MarketCustomerResearchController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Market & Customer Research";
            ViewData["ProductDescription"] = "Understand your market, customers, and competitors before making important product decisions.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Market-Customer-Research/Competitor-Analysis", "Competitor Analysis", "Analyze competitors, positioning, and market opportunities." },
                new[] { "/Market-Customer-Research/Customer-Research", "Customer Research", "Understand customer needs, motivations, and behavior." },
                new[] { "/Market-Customer-Research/Customer-Segmentation", "Customer Segmentation", "Define audiences and create more relevant product experiences." },
                new[] { "/Market-Customer-Research/Market-Customer_Research", "Market Customer Research", "Discover market and customer insights for stronger decisions." },
                new[] { "/Market-Customer-Research/Market-Validation", "Market Validation", "Validate product opportunities before investing in delivery." },
                new[] { "/Market-Customer-Research/User-Research", "User Research", "Learn how users behave and where their experience can improve." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
        }

        [HttpGet("Competitor-Analysis")]
        public IActionResult CompetitorAnalysis()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/CompetitorAnalysis.cshtml");
        }

        [HttpGet("Customer-Research")]
        public IActionResult CustomerResearch()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/CustomerResearch.cshtml");
        }

        [HttpGet("Customer-Segmentation")]
        public IActionResult CustomerSegmentation()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/CustomerSegmentation.cshtml");
        }

        [HttpGet("Market-Customer_Research")]
        public IActionResult MarketCustomerResearch()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/MarketCustomerResearch.cshtml");
        }

        [HttpGet("User-Research")]
        public IActionResult UserResearch()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/UserResearch.cshtml");
        }
        [HttpGet("Market-Validation")]
        public IActionResult MarketValidation()
        {
            return View("~/Views/Productmanagement/MarketCustomerResearch/Marketvalidation.cshtml");
        }
    }
}