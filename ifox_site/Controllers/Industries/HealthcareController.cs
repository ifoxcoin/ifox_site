using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Healthcare")]
    public class HealthcareController : Controller
    {
        [HttpGet("Appointment Scheduling")]
        public IActionResult AppointmentScheduling()
        {
            return View("~/Views/Industries/healthcare/AppointmentScheduling.cshtml");
        }

        [HttpGet("Healthcare CRM")]
        public IActionResult HealthcareCRM()
        {
            return View("~/Views/Industries/healthcare/AppointmentScheduling.cshtml");
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