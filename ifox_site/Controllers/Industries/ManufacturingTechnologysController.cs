using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Industries/Manufacturing")]
    public class ManufacturingTechnologyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Industries/manufacturing technology/Index.cshtml");
        }

        [HttpGet("Inventory Management")]
        public IActionResult InventoryManagement()
        {
            return View("~/Views/Industries/manufacturing technology/InventoryManagement.cshtml");
        }

        [HttpGet("Manufacturing Automation")]
        public IActionResult ManufacturingAutomation()
        {
            return View("~/Views/Industries/manufacturing technology/ManufacturingAutomation.cshtml");
        }

        [HttpGet("Manufacturing ERP")]
        public IActionResult ManufacturingERP()
        {
            return View("~/Views/Industries/manufacturing technology/ManufacturingERP.cshtml");
        }

        [HttpGet("Production Management")]
        public IActionResult ProductionManagement()
        {
            return View("~/Views/Industries/manufacturing technology/ProductionManagement.cshtml");
        }

        [HttpGet("Quality Management")]
        public IActionResult QualityManagement()
        {
            return View("~/Views/Industries/manufacturing technology/QualityManagement.cshtml");
        }

        [HttpGet("Supply Chain Management")]
        public IActionResult SupplyChainManagement()
        {
            return View("~/Views/Industries/manufacturing technology/SupplyChainManagement.cshtml");
        }
    }
}