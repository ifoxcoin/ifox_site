using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile-Developer")]
    public class MobileDevelopersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["HireTitle"] = "Mobile Developers";
            ViewData["HireDescription"] = "Hire mobile specialists to create reliable, engaging applications across devices and platforms.";
            ViewData["HireItems"] = new[]
            {
                new[] { "/Mobile-Developer/Android-Developer", "Android Developers", "Build native Android applications" },
                new[] { "/Mobile-Developer/Flutter-Developer", "Flutter Developers", "Create cross-platform mobile experiences" },
                new[] { "/Mobile-Developer/IOS-Developer", "iOS Developers", "Deliver polished iPhone and iPad apps" },
                new[] { "/Mobile-Developer/React-Native-Developer", "React Native Developers", "Develop efficient cross-platform apps" }
            };
            return View("~/Views/HireDevelopers/CategoryIndex.cshtml");
        }

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