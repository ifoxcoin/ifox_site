using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile Developer")]
    public class Mobile_Developer : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Android Developer")]
        public IActionResult AndroidDevelopers()
        {
            return View();
        }

        [HttpGet("Flutter Developers")]
        public IActionResult FlutterDeveloper()
        {
            return View();
        }

        [HttpGet("IOS Developer")]
        public IActionResult IOSDeveloper()
        {
            return View();
        }

        [HttpGet("React Native Developer")]
        public IActionResult ReactNativeDeveloper()
        {
            return View();
        }
    }
}