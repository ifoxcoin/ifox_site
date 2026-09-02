using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Education Technology")]
    public class EducationTechnologyController : Controller
    {
        [HttpGet("College Management")]
        public IActionResult CollegeManagement()
        {
            return View("~/Views/Industries/Education Technology/CollegeManagement.cshtml");
        }

        [HttpGet("Examination Management")]
        public IActionResult ExaminationManagement()
        {
            return View("~/Views/Industries/Education Technology/ExaminationManagement.cshtml");
        }

        [HttpGet("Fee Management")]
        public IActionResult FeeManagement()
        {
            return View("~/Views/Industries/Education Technology/FeeManagement.cshtml");
        }

        [HttpGet("Learning Management")]
        public IActionResult LearningManagement()
        {
            return View("~/Views/Industries/Education Technology/LearningManagement.cshtml");
        }

        [HttpGet("School Management")]
        public IActionResult SchoolManagement()
        {
            return View("~/Views/Industries/Education Technology/SchoolManagement.cshtml");
        }

        [HttpGet("Student Management")]
        public IActionResult StudentManagement()
        {
            return View("~/Views/Industries/Education Technology/StudentManagement.cshtml");
        }
    }
}