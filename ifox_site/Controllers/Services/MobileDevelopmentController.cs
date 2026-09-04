using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile Development")]
    public class MobileDevelopmentController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Android")]
        
        public IActionResult Android()
        {
            return View();
        }

        [HttpGet("Flutter")]
        public IActionResult Flutter()
        {
            return View();
        }

        [HttpGet("Enterprise Apps")]
        public IActionResult EnterpriseApps()
        {
            return View();
        }
        [HttpGet("IOS")]
        public IActionResult IOS()
        {
            return View();
        }
        [HttpGet("React Native")]
        public IActionResult ReactNative()
        {
            return View();
        }

    }
}