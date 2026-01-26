using ifox_site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ifox_site.Controllers
{
    [Route("hire-developers")]
    public class HireDevelopers : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HireDevelopers(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("Hire-Dot-Net-Developer")]
        public ActionResult HireDotNetDeveloper()
        {
            return View();
        }
        [HttpGet("Dot-Net-Developer")]
        public ActionResult DotNetDeveloper()
        {
            return View();
        }
        [HttpGet("CRM-Developer")]
        public ActionResult CRMDeveloper()
        {
            return View();
        }
        [HttpGet("PHP-Developer")]
        public ActionResult PHPDeveloper()
        {
            return View();
        }
        [HttpGet("Mobile-App-Developer")]
        public ActionResult MobileAppDeveloper()
        {
            return View();
        }
    }
}