using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("RetailandEcommerce")]
    public class RetailandEcommerceController : Controller
    {
        [HttpGet("")]
        [HttpGet("~/Retail")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Retail & Digital Commerce";
            ViewData["IndustryDescription"] = "Connected retail technology that creates smoother customer journeys and more efficient commerce operations.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/RetailandEcommerce/Customer%20Engagement", "Customer Engagement", "Create smoother customer journeys and stronger loyalty." },
                new[] { "/RetailandEcommerce/E-Commerce%20Development", "E-Commerce Development", "Build scalable digital commerce experiences." },
                new[] { "/RetailandEcommerce/Inventory%20Management", "Inventory Management", "Improve stock visibility across your operations." },
                new[] { "/RetailandEcommerce/Payment%20Integration", "Payment Integration", "Connect secure and convenient payment journeys." },
                new[] { "/RetailandEcommerce/Point%20Of%20Sale", "Point of Sale", "Modernize checkout and retail operations." },
                new[] { "/RetailandEcommerce/Retail%20Management", "Retail Management", "Manage customers, products, and commerce in one place." }
            };
            return View("~/Views/Industries/Index.cshtml");
        }

        [HttpGet("Customer Engagement")]
        public IActionResult CustomerEngagement()
        {
            return View("~/Views/Industries/Retail and Ecommerce/CustomerEngagement.cshtml");
        }

        [HttpGet("E-Commerce Development")]
        public IActionResult ECommerceDevelopment()
        {
            return View("~/Views/Industries/Retail and Ecommerce/ECommerceDevelopment.cshtml");
        }

        [HttpGet("Inventory Management")]
        public IActionResult InventoryManagement()
        {
            return View("~/Views/Industries/Retail and Ecommerce/InventoryManagement.cshtml");
        }

        [HttpGet("Payment Integration")]
        public IActionResult PaymentIntegration()
        {
            return View("~/Views/Industries/Retail and Ecommerce/PaymentIntegration.cshtml");
        }

        [HttpGet("Point Of Sale")]
        public IActionResult PointOfSale()
        {
            return View("~/Views/Industries/Retail and Ecommerce/PointOfSale.cshtml");
        }

        [HttpGet("Retail Management")]
        public IActionResult RetailManagement()
        {
            return View("~/Views/Industries/Retail and Ecommerce/RetailManagement.cshtml");
        }
    }
}