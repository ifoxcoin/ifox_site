using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("CloudSolutions")]
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
            return View("~/Views/Services/CloudSolutions/AWS.cshtml");
                }

        [HttpGet("Cloud Migration")]
        public IActionResult CloudMigration()
        {
            return View("~/Views/Services/CloudSolutions/CloudMigration.cshtml");
        }

        [HttpGet("DevOps")]
        public IActionResult DevOps()
        {
            return View("~/Views/Services/CloudSolutions/DevOps.cshtml");
        }

        [HttpGet("Infrastructure")]
        public IActionResult Infrastructure()
        {
            return View("~/Views/Services/CloudSolutions/Infrastructure.cshtml");
        }
        [HttpGet("Microsoft Azure")]
        public IActionResult MicrosoftAzure()
        {
            return View("~/Views/Services/CloudSolutions/MicrosoftAzure.cshtml");
        }
    }
}