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
            ViewData["ServiceTitle"] = "Microsoft Dynamics 365 CRM";
            ViewData["ServiceDescription"] = "Transform customer operations with connected Dynamics 365 CRM and Power Platform solutions.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/dynamics-365-crm-services/CRM%20Consulting", "CRM Consulting", "Align CRM strategy with business goals." },
                new[] { "/dynamics-365-crm-services/Customization", "Customization", "Shape Dynamics 365 around your processes." },
                new[] { "/dynamics-365-crm-services/Implementation", "Implementation", "Deploy CRM with a practical delivery approach." },
                new[] { "/dynamics-365-crm-services/Integration", "Integration", "Connect CRM with your business systems." },
                new[] { "/dynamics-365-crm-services/Migration", "Migration", "Move CRM data and processes safely." },
                new[] { "/dynamics-365-crm-services/On-Premises", "On-Premises CRM", "Support on-premises Dynamics environments." },
                new[] { "/dynamics-365-crm-services/Plugin%20Development", "Plugin Development", "Extend CRM with reliable custom plugins." },
                new[] { "/dynamics-365-crm-services/Power%20Platform", "Power Platform", "Build connected apps and automations." },
                new[] { "/dynamics-365-crm-services/Support", "CRM Support", "Keep your CRM platform healthy and effective." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
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