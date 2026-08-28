using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Windows Application")]
    public class Windows_Application : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Billing Software")]
        public IActionResult BillingSoftware()
        {
            return View();
        }

        [HttpGet("Hospital Management")]
        public IActionResult HospitalManagement()
        {
            return View();
        }

        [HttpGet("Inventory Management")]
        public IActionResult InventoryManagement()
        {
            return View();
        }

        [HttpGet("Manufacturing Management")]
        public IActionResult ManufaturingManagement()
        {
            return View();
        }
        [HttpGet("POS Software")]
        public IActionResult PosSoftware()
        {
            return View();
        }
        [HttpGet("School Management")]
        public IActionResult SchoolManagement()
        {
            return View();
        }

        [HttpGet("E-Commerce")]
        public IActionResult ECommerce()
        {
            return View();
        }
    }
}