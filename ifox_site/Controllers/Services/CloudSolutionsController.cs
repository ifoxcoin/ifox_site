using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("CloudSolutions")]
    public class CloudSolutionsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ServiceTitle"] = "Cloud Solutions";
            ViewData["ServiceDescription"] = "Secure, scalable cloud solutions that improve infrastructure, delivery, and business agility.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/CloudSolutions/AWS", "AWS Solutions", "Build and operate reliable AWS cloud platforms." },
                new[] { "/CloudSolutions/Cloud%20Migration", "Cloud Migration", "Move workloads to the cloud with confidence." },
                new[] { "/CloudSolutions/DevOps", "DevOps", "Connect development, delivery, and operations." },
                new[] { "/CloudSolutions/Infrastructure", "Cloud Infrastructure", "Create secure and resilient cloud foundations." },
                new[] { "/CloudSolutions/Microsoft%20Azure", "Microsoft Azure", "Use Azure to modernize applications and data." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
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