using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Industries/Manufacturing")]
    public class ManufacturingTechnologyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Manufacturing Technology";
            ViewData["IndustryDescription"] = "Connected manufacturing platforms that improve production visibility, quality, inventory, and supply chain performance.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/Industries/Manufacturing/Inventory%20Management", "Inventory Management", "Improve inventory visibility and control." },
                new[] { "/Industries/Manufacturing/Manufacturing%20Automation", "Manufacturing Automation", "Automate production operations and workflows." },
                new[] { "/Industries/Manufacturing/Manufacturing%20ERP", "Manufacturing ERP", "Connect business operations with one integrated platform." },
                new[] { "/Industries/Manufacturing/Production%20Management", "Production Management", "Plan and manage production with confidence." },
                new[] { "/Industries/Manufacturing/Quality%20Management", "Quality Management", "Improve quality control and compliance." },
                new[] { "/Industries/Manufacturing/Supply%20Chain%20Management", "Supply Chain Management", "Build a more connected and resilient supply chain." }
            };
            return View("~/Views/Industries/Index.cshtml");
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