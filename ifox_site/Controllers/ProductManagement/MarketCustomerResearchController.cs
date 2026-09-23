using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Market-Customer-Research")]
    public class MarketCustomerResearchController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/ProductManagement/MarketCustomerResearch/Index.cshtml");
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