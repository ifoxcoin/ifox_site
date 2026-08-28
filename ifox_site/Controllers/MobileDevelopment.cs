using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Mobile Development")]
    public class Mobile_Development : Controller
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

        [HttpGet("Enterprise App")]
        public IActionResult EnterpriseApp()
        {
            return View();
        }
        [HttpGet("IOS")]
        public IActionResult IOS()
        {
            return View();
        }
        [HttpGet("React")]
        public IActionResult React()
        {
            return View();
        }
        [HttpGet("LMS")]
        public IActionResult LMS()
        {
            return View();
        }

    }
}