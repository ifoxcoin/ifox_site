using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("AI Solutions")]
    public class AISolutionsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ServiceTitle"] = "AI Solutions";
            ViewData["ServiceDescription"] = "Practical AI solutions that automate work, improve decisions, and create better customer experiences.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/AI%20Solutions/AI%20Automation", "AI Automation", "Automate repetitive work with intelligent workflows." },
                new[] { "/AI%20Solutions/AI%20Chatbots", "AI Chatbots", "Create helpful conversational experiences." },
                new[] { "/AI%20Solutions/Copilot", "Copilot", "Equip teams with intelligent, context-aware assistance." },
                new[] { "/AI%20Solutions/Document%20AI", "Document AI", "Extract and process information from documents." },
                new[] { "/AI%20Solutions/OCR", "OCR", "Convert documents and images into usable data." },
                new[] { "/AI%20Solutions/Open%20AI", "OpenAI Solutions", "Build modern applications with advanced AI models." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
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
            return View("~/Views/Services/AISolutions/OpenAI.cshtml");
        }
    }
}