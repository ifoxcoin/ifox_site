using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("AI Solutions")]
    public class AISolutionsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("AI Automation")]
        public IActionResult AIAutomation()
        {
            return View("~/Views/Services/AISolutions/AIAutomation.cshtml");
        }

        [HttpGet("AI Chatbots")]
        public IActionResult AIChatbots()
        {
            return View("~/Views/Services/AISolutions/AIChatbots.cshtml");
        }

        [HttpGet("Copilot")]
        public IActionResult Copilot()
        {
            return View("~/Views/Services/AISolutions/Copilot.cshtml");
        }

        [HttpGet("Document AI")]
        public IActionResult DocumentAI()
        {
            return View("~/Views/Services/AISolutions/DocumentAI.cshtml");
        }
        [HttpGet("OCR")]
        public IActionResult OCR()
        {
            return View("~/Views/Services/AISolutions/OCR.cshtml");
        }
        [HttpGet("Open AI")]
        public IActionResult OpenAI()
        {
            return View("~/Views/Services/AISolutions/AIAutomation.cshtml");
        }
    }
}