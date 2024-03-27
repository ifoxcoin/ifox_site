using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    public class DynamicsCRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
