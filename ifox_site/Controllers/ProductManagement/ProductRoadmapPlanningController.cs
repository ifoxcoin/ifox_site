using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Roadmap-Planning")]
    public class ProductRoadmapPlanningController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/ProductManagement/ProductRoadmapPlanning/Index.cshtml");
        }

        [HttpGet("Feature-Prioritization")]
        public IActionResult FeaturePrioritization()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/FeaturePrioritization.cshtml");
        }

        [HttpGet("Product-Backlog")]
        public IActionResult ProductBacklog()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/ProductBacklog.cshtml");
        }

        [HttpGet("Product-Lifecycle-Management")]
        public IActionResult ProductLifecycleManagement()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/ProductLifecycleManagement.cshtml");
        }

        [HttpGet("Product-Roadmap-Planning")]
        public IActionResult ProductRoadmapPlanning()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/ProductRoadmapPlanning.cshtml");
        }

        [HttpGet("Release-Roadmap")]
        public IActionResult ReleaseRoadmap()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/ReleaseRoadmap.cshtml");
        }

        [HttpGet("Resource-Planning")]
        public IActionResult ResourcePlanning()
        {
            return View("~/Views/Productmanagement/ProductRoadmapPlanning/ResourcePlanning.cshtml");
        }
    }
}