using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("AI Solutions")]
    public class AI_Solution : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("AI Automation")]
        public IActionResult AiAutomation()
        {
            return View();
        }

        [HttpGet("AI Chatbots")]
        public IActionResult AiChatbots()
        {
            return View();
        }

        [HttpGet("Copilot")]
        public IActionResult Copilot()
        {
            return View();
        }

        [HttpGet("Document AI")]
        public IActionResult DocumentAi()
        {
            return View();
        }
        [HttpGet("OCR")]
        public IActionResult OCR()
        {
            return View();
        }
        [HttpGet("Open AI")]
        public IActionResult OpenAi()
        {
            return View();
        }
    }
}