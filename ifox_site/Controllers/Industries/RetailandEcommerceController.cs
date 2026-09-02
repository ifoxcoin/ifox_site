using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("RetailandEcommerce")]
    public class RetailandEcommerceController : Controller
    {
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