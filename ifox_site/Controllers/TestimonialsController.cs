using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifox_site.Controllers
{
    [Route("testimonials")]
    public class TestimonialsController : Controller
    {
        // GET: TestimonialsController
        [HttpGet("")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestimonialsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestimonialsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestimonialsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestimonialsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestimonialsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}