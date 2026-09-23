using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Product-Development")]
    public class ProductDevelopmentController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/ProductManagement/ProductDevelopment/Index.cshtml");
        }

        [HttpGet("Feature-Development")]
        public IActionResult FeatureDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/FeatureDevelopment.cshtml");
        }

        [HttpGet("MVP-Development")]
        public IActionResult MVPDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/MVPDevelopment.cshtml");
        }

        [HttpGet("Product-Design")]
        public IActionResult ProductDesign()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDesign.cshtml");
        }

        [HttpGet("Product-Development")]
        public IActionResult ProductDevelopment()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDevelopment.cshtml");
        }

        [HttpGet("Product-Development-Launch")]
        public IActionResult ProductDevelopmentLaunch()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductDevelopmentLaunch.cshtml");
        }

        [HttpGet("Product-Engineering")]
        public IActionResult ProductEngineering()
        {
            return View("~/Views/Productmanagement/ProductDevelopment/ProductEngineering.cshtml");
        }
    }
}