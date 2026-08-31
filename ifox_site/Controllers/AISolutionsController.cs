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
            return View();
        }

        [HttpGet("AI Chatbots")]
        public IActionResult AIChatbots()
        {
            return View();
        }

        [HttpGet("Copilot")]
        public IActionResult Copilot()
        {
            return View();
        }

        [HttpGet("Document AI")]
        public IActionResult DocumentAI()
        {
            return View();
        }
        [HttpGet("OCR")]
        public IActionResult OCR()
        {
            return View();
        }
        [HttpGet("Open AI")]
        public IActionResult OpenAI()
        {
            return View();
        }
    }
}