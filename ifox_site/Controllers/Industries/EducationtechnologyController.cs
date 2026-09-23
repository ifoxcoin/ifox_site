using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Education Technology")]
    public class EducationTechnologyController : Controller
    {
        [HttpGet("")]
        [HttpGet("~/Education")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Education Technology";
            ViewData["IndustryDescription"] = "Digital education platforms that simplify administration, improve learning experiences, and connect institutions.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/Education%20Technology/College%20Management", "College Management", "Connect administration, staff, and students." },
                new[] { "/Education%20Technology/Examination%20Management", "Examination Management", "Organize assessments and examination workflows." },
                new[] { "/Education%20Technology/Fee%20Management", "Fee Management", "Simplify fee collection and financial visibility." },
                new[] { "/Education%20Technology/Learning%20Management", "Learning Management", "Deliver connected and engaging learning experiences." },
                new[] { "/Education%20Technology/School%20Management", "School Management", "Manage day-to-day school operations efficiently." },
                new[] { "/Education%20Technology/Student%20Management", "Student Management", "Support student records, engagement, and success." }
            };
            return View("~/Views/Industries/Index.cshtml");
        }

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