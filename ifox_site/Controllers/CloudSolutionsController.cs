using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Cloud Solutions")]
    public class CloudSolutionsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("AWS")]
        public IActionResult AWS()
        {
            return View();
                }

        [HttpGet("Cloud Migration")]
        public IActionResult CloudMigration()
        {
            return View();
        }

        [HttpGet("DevOps")]
        public IActionResult DevOps()
        {
            return View();
        }

        [HttpGet("Infrastructure")]
        public IActionResult Infrastructure()
        {
            return View();
        }
        [HttpGet("Microsoft Azure")]
        public IActionResult MicrosoftAzure()
        {
            return View();
        }
    }
}