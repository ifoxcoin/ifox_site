using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("dynamics-365-crm-services")]
    public class DynamicsCRMController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Implementation")]
        public IActionResult Implementation()
        {
            return View();
        }

        [HttpGet("Support")]
        public IActionResult Support()
        {
            return View();
        }

        [HttpGet("Integration")]
        public IActionResult Integration()
        {
            return View();
        }
        [HttpGet("On-Premises")]
        public IActionResult OnPremises()
        {
            return View();
        }
        [HttpGet("Customization")]
        public IActionResult Customization()
        {
            return View();
        }
        [HttpGet("Migration")]
        public IActionResult Migration()
        {
            return View();
        }

    }
}