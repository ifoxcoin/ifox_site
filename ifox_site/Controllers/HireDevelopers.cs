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
    public class HireDevelopers : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HireDevelopers(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HireDotNetDeveloper()
        {
            return View();
        }
    }
}
