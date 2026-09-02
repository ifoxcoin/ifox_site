using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile Developer")]
    public class MobileDeveloperController : Controller
    {
        [HttpGet("Android Developer")]
        public IActionResult AndroidDeveloper()
        {
            return View();
        }

        [HttpGet("Flutter Developer")]
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