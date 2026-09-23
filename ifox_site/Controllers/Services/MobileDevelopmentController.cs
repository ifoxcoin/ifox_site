using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile Development")]
    public class MobileDevelopmentController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ServiceTitle"] = "Mobile Development";
            ViewData["ServiceDescription"] = "Create reliable mobile applications that connect customers, teams, and business operations.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/Mobile%20Development/Android", "Android Development", "Build native Android applications." },
                new[] { "/Mobile%20Development/Flutter", "Flutter Development", "Create efficient cross-platform applications." },
                new[] { "/Mobile%20Development/Enterprise%20Apps", "Enterprise Apps", "Deliver secure mobile tools for business teams." },
                new[] { "/Mobile%20Development/IOS", "iOS Development", "Build polished iPhone and iPad experiences." },
                new[] { "/Mobile%20Development/React%20Native", "React Native", "Develop maintainable cross-platform mobile apps." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
        }

        [HttpGet("Android")]
        
        public IActionResult Android()
        {
            return View("~/Views/Services/Mobile Development/Android.cshtml");
        }

        [HttpGet("Flutter")]
        public IActionResult Flutter()
        {
            return View("~/Views/Services/Mobile Development/Flutter.cshtml");
        }

        [HttpGet("Enterprise Apps")]
        public IActionResult EnterpriseApps()
        {
            return View("~/Views/Services/Mobile Development/Enterprise App.cshtml");
        }
        [HttpGet("IOS")]
        public IActionResult IOS()
        {
            return View("~/Views/Services/Mobile Development/IOS.cshtml");
        }
        [HttpGet("React Native")]
        public IActionResult ReactNative()
        {
            return View("~/Views/Services/Mobile Development/React.cshtml");
        }

    }
}