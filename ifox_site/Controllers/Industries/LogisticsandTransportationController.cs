using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Logistics and transportation")]
    public class LogisticsAndTransportationController : Controller
    {
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