using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile-Developer")]
    public class MobileDevelopersController : Controller
    {
        [HttpGet("Android-Developer")]
        public IActionResult AndroidDeveloper()
        {
            return View("~/Views/HireDevelopers/MobileDeveloper/AndroidDeveloper.cshtml");
        }

        [HttpGet("Flutter-Developer")]
        public IActionResult FlutterDeveloper()
        {
            return View("~/Views/HireDevelopers/MobileDeveloper/FlutterDeveloper.cshtml");
        }

        [HttpGet("IOS-Developer")]
        public IActionResult IOSDeveloper()
        {
            return View("~/Views/HireDevelopers/MobileDeveloper/IOSDeveloper.cshtml");
        }

        [HttpGet("React-Native-Developer")]
        public IActionResult ReactNativeDeveloper()
        {
            return View("~/Views/HireDevelopers/MobileDeveloper/ReactNativeDeveloper.cshtml");
        }
    }
}