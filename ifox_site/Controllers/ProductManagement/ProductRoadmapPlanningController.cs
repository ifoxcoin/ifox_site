using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Roadmap-Planning")]
    public class ProductRoadmapPlanningController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ProductTitle"] = "Product Roadmap Planning";
            ViewData["ProductDescription"] = "Create a clear product direction, prioritize the right work, and align delivery with business goals.";
            ViewData["ProductItems"] = new[]
            {
                new[] { "/Product-Roadmap-Planning/Feature-Prioritization", "Feature Prioritization", "Rank opportunities using value, effort, risk, and strategy." },
                new[] { "/Product-Roadmap-Planning/Product-Backlog", "Product Backlog", "Maintain a clear and actionable list of product work." },
                new[] { "/Product-Roadmap-Planning/Product-Lifecycle-Management", "Product Lifecycle Management", "Manage products from introduction through maturity and improvement." },
                new[] { "/Product-Roadmap-Planning/Product-Roadmap-Planning", "Product Roadmap Planning", "Communicate direction, outcomes, themes, and delivery horizons." },
                new[] { "/Product-Roadmap-Planning/Release-Roadmap", "Release Roadmap", "Coordinate upcoming releases around customer and business value." },
                new[] { "/Product-Roadmap-Planning/Resource-Planning", "Resource Planning", "Align people, capacity, and investment with product priorities." }
            };
            return View("~/Views/ProductManagement/Overview.cshtml");
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