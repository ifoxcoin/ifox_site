using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("FinancialTechnology")]
    public class FinancialtechnologyController : Controller
    {
        [HttpGet("")]
        [HttpGet("~/Finance")]
        public IActionResult Index()
        {
            ViewData["IndustryTitle"] = "Financial Technology";
            ViewData["IndustryDescription"] = "Secure, scalable financial technology that connects data, automates processes, and supports better decisions.";
            ViewData["IndustryItems"] = new[]
            {
                new[] { "/FinancialTechnology/Banking%20Applications", "Banking Applications", "Build secure and connected banking experiences." },
                new[] { "/FinancialTechnology/Financial%20CRM", "Financial CRM", "Strengthen customer relationships with connected data." },
                new[] { "/FinancialTechnology/Financial%20Management", "Financial Management", "Improve financial control and decision-making." },
                new[] { "/FinancialTechnology/Loan%20Management", "Loan Management", "Streamline lending workflows and customer service." },
                new[] { "/FinancialTechnology/Payment%20Solutions", "Payment Solutions", "Deliver secure and efficient payment experiences." },
                new[] { "/FinancialTechnology/Risk%20Management", "Risk Management", "Identify, monitor, and manage financial risk." }
            };
            return View("~/Views/Industries/Index.cshtml");
        }

        [HttpGet("Banking Applications")]
        public IActionResult BankingApplications()
        {
            return View("~/Views/Industries/Financial Technology/BankingApplications.cshtml");
        }

        [HttpGet("Financial CRM")]
        public IActionResult FinancialCRM()
        {
            return View("~/Views/Industries/Financial Technology/FinancialCRM.cshtml");
        }

        [HttpGet("Financial Management")]
        public IActionResult FinancialManagement()
        {
            return View("~/Views/Industries/Financial Technology/FinancialManagement.cshtml");
        }

        [HttpGet("Loan Management")]
        public IActionResult LoanManagement()
        {
            return View("~/Views/Industries/Financial Technology/LoanManagement.cshtml");
        }

        [HttpGet("Payment Solutions")]
        public IActionResult PaymentSolutions()
        {
            return View("~/Views/Industries/Financial Technology/PaymentSolutions.cshtml");
        }

        [HttpGet("Risk Management")]
        public IActionResult RiskManagement()
        {
            return View("~/Views/Industries/Financial Technology/RiskManagement.cshtml");
        }
        [HttpGet("Analytics REporting")]
        public IActionResult AnalyticsReporting()
        {
            return View("~/Views/Industries/Financial Technology/AnalyticsREporting.cshtml");
        }
    }
}