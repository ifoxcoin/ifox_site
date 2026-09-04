using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("dynamics-365-crm-services")]
    public class DynamicsCRMController : Controller
    {
        [HttpGet("CRM Consulting")]
        public IActionResult CRMConsulting()
        {
            return View("~/Views/Services/DynamicsCRM/CRMConsulting.cshtml");
        }

        [HttpGet("Plugin Development")]
        public IActionResult PluginDevelopment()
        {
            return View("~/Views/Services/DynamicsCRM/PluginDevelopment.cshtml");
        }

        [HttpGet("Power Platform")]
        public IActionResult PowerPlatform()
        {
            return View("~/Views/Services/DynamicsCRM/PowerPlatform.cshtml");
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Implementation")]
        public IActionResult Implementation()
        {
            return View("~/Views/Services/DynamicsCRM/Implementation.cshtml");
        }

        [HttpGet("Support")]
        public IActionResult Support()
        {
            return View("~/Views/Services/DynamicsCRM/Support.cshtml");
        }

        [HttpGet("Integration")]
        public IActionResult Integration()
        {
            return View("~/Views/Services/DynamicsCRM/Integration.cshtml");
        }
        [HttpGet("On-Premises")]
        public IActionResult OnPremises()
        {
            return View("~/Views/Services/DynamicsCRM/OnPremises.cshtml");
        }
        [HttpGet("Customization")]
        public IActionResult Customization()
        {
            return View("~/Views/Services/DynamicsCRM/Customization.cshtml");
        }
        [HttpGet("Migration")]
        public IActionResult Migration()
        {
            return View("~/Views/Services/DynamicsCRM/Migration.cshtml");
        }

    }
}