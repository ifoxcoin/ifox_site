using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("FinancialTechnology")]
    public class FinancialtechnologyController : Controller
    {
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