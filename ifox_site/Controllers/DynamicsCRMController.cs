using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    public class DynamicsCRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Implementation()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

         public IActionResult Integration()
        {
            return View();
        }
        public IActionResult OnPremises()
        {
            return View();
        }
        public IActionResult Customization()
        {
            return View();
        }
        public IActionResult Migration()
        {
            return View();
        }
        
    }
}
