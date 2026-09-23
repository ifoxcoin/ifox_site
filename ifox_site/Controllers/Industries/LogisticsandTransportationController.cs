using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Logistics and transportation")]
    public class LogisticsAndTransportationController : Controller
    {
        [HttpGet("")]
        [HttpGet("~/Logistics")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Logistics & Transportation";
            ViewData["IndustryDescription"] = "Connected logistics solutions that help teams plan, track, optimize, and deliver with confidence.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/Logistics%20and%20transportation/Fleet%20Management", "Fleet Management", "Monitor vehicles, drivers, and field operations." },
                new[] { "/Logistics%20and%20transportation/Logistics%20Management", "Logistics Management", "Coordinate logistics operations from one platform." },
                new[] { "/Logistics%20and%20transportation/Route%20Optimization", "Route Optimization", "Plan efficient routes and reduce delivery costs." },
                new[] { "/Logistics%20and%20transportation/Shipment%20Tracking", "Shipment Tracking", "Give teams and customers real-time delivery visibility." },
                new[] { "/Logistics%20and%20transportation/Supply%20Chain%20Automation", "Supply Chain Automation", "Automate connected supply chain workflows." },
                new[] { "/Logistics%20and%20transportation/Warehouse%20Management", "Warehouse Management", "Improve warehouse accuracy, speed, and control." }
            };
            return View("~/Views/Industries/Index.cshtml");
        }

        [HttpGet("Fleet Management")]
        public IActionResult FleetManagement()
        {
            return View("~/Views/Industries/Logistics and transportation/FleetManagement.cshtml");
        }

        [HttpGet("Logistics Management")]
        public IActionResult LogisticsManagement()
        {
            return View("~/Views/Industries/Logistics and transportation/LogisticsManagement.cshtml");
        }

        [HttpGet("Route Optimization")]
        public IActionResult RouteOptimization()
        {
            return View("~/Views/Industries/Logistics and transportation/RouteOptimization.cshtml");
        }

        [HttpGet("Shipment Tracking")]
        public IActionResult ShipmentTracking()
        {
            return View("~/Views/Industries/Logistics and transportation/ShipmentTracking.cshtml");
        }

        [HttpGet("Supply Chain Automation")]
        public IActionResult SupplyChainAutomation()
        {
            return View("~/Views/Industries/Logistics and transportation/SupplyChainAutomation.cshtml");
        }

        [HttpGet("Warehouse Management")]
        public IActionResult WarehouseManagement()
        {
            return View("~/Views/Industries/Logistics and transportation/WarehouseManagement.cshtml");
        }
    }
}