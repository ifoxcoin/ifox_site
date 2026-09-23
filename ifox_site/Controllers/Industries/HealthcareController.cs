using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Healthcare")]
    public class HealthcareController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Healthcare Technology Solutions";
            ViewData["IndustryDescription"] = "Connected digital systems that help healthcare organizations improve operations, patient engagement, and outcomes.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/Healthcare/Healthcare%20Management", "Healthcare Management", "Purpose-built technology designed around your organization." },
                new[] { "/Healthcare/Patient%20Management", "Patient Management", "Coordinate patient journeys and care operations." },
                new[] { "/Healthcare/Appointment%20Scheduling", "Appointment & Scheduling", "Simplify scheduling and improve appointment experiences." },
                new[] { "/Healthcare/Healthcare%20CRM", "Healthcare CRM", "Connect patient engagement and relationship management." },
                new[] { "/Healthcare/Telemedicine", "Telemedicine", "Deliver secure and accessible remote care experiences." },
                new[] { "/Healthcare/Medical%20Data%20Management", "Medical Data Management", "Manage healthcare data securely and efficiently." }
            };
            return View("~/Views/Industries/Index.cshtml");
        }

        [HttpGet("Appointment Scheduling")]
        public IActionResult AppointmentScheduling()
        {
            return View("~/Views/Industries/healthcare/AppointmentScheduling.cshtml");
        }

        [HttpGet("Healthcare CRM")]
        public IActionResult HealthcareCRM()
        {
            return View("~/Views/Industries/healthcare/HealthcareCRM.cshtml");
        }

        [HttpGet("Healthcare Management")]
        public IActionResult HealthcareManagement()
        {
            return View("~/Views/Industries/healthcare/HealthcareManagement.cshtml");
        }

        [HttpGet("Medical Data Management")]
        public IActionResult MedicalDataManagement()
        {
            return View("~/Views/Industries/healthcare/MedicalDataManagement.cshtml");
        }

        [HttpGet("Patient Management")]
        public IActionResult PatientManagement()
        {
            return View("~/Views/Industries/healthcare/PatientManagement.cshtml");
        }

        [HttpGet("Telemedicine")]
        public IActionResult Telemedicine()
        {
            return View("~/Views/Industries/healthcare/Telemedicine.cshtml");
        }
    }
}