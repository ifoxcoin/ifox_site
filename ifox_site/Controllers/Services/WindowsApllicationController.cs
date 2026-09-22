using Microsoft.AspNetCore.Mvc;

namespace ifox_site.Controllers
{
    [Route("Windows Application")]
    public class WindowsApplicationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["ServiceTitle"] = "Windows Applications";
            ViewData["ServiceDescription"] = "Build dependable desktop applications that support efficient day-to-day business operations.";
            ViewData["ServiceItems"] = new[]
            {
                new[] { "/Windows%20Application/Billing%20Software", "Billing Software", "Simplify billing and financial workflows." },
                new[] { "/Windows%20Application/E-Commerce", "E-Commerce Applications", "Support connected desktop commerce operations." },
                new[] { "/Windows%20Application/Hospital%20Management", "Hospital Management", "Coordinate hospital processes and information." },
                new[] { "/Windows%20Application/Inventory%20Management", "Inventory Management", "Track products, stock, and movement accurately." },
                new[] { "/Windows%20Application/Manufacturing%20Management", "Manufacturing Management", "Manage production workflows and resources." },
                new[] { "/Windows%20Application/POS%20Software", "POS Software", "Deliver efficient point-of-sale operations." },
                new[] { "/Windows%20Application/School%20Management", "School Management", "Connect administration, staff, and student operations." }
            };
            return View("~/Views/Services/CategoryIndex.cshtml");
        }

        [HttpGet("Billing Software")]
        public IActionResult BillingSoftware()
        {
            return WindowsDetail("Billing Software", "Smart billing solutions", "Manage invoices, payments, customers, taxes, and financial reporting with dependable billing software built for your business.", new[]
            {
                new[] { "Invoice Management", "Create, manage, and track professional invoices efficiently." },
                new[] { "Payments and Receipts", "Record payments and generate accurate receipts for every transaction." },
                new[] { "Tax and Discount Rules", "Apply taxes, discounts, and pricing rules consistently." },
                new[] { "Financial Reports", "Review sales, outstanding balances, and billing performance." },
                new[] { "Customer Management", "Keep customer billing details and transaction history organized." }
            }, new[]
            {
                new[] { "Why Choose Our Billing Software", "A centralized billing platform reduces manual work, improves accuracy, and gives your team a clear view of financial activity." },
                new[] { "Built for Business Growth", "Flexible workflows and reliable reporting help the billing process grow with your products, customers, and transaction volume." }
            });
        }

        [HttpGet("Hospital Management")]
        public IActionResult HospitalManagement()
        {
            return WindowsDetail("Hospital Management System", "Healthcare management systems", "Connect hospital administration, clinical workflows, patient records, billing, and reporting in one dependable management system.", new[]
            {
                new[] { "Patient Registration", "Manage patient registration, profiles, visits, and medical history." },
                new[] { "Appointments and Scheduling", "Coordinate doctors, departments, appointments, and available resources." },
                new[] { "Pharmacy and Laboratory", "Track prescriptions, laboratory requests, results, and inventory." },
                new[] { "Billing and Insurance", "Handle treatment billing, payments, insurance, and receipts accurately." },
                new[] { "Reports and Security", "Generate operational reports while protecting sensitive healthcare data." }
            }, new[]
            {
                new[] { "Connected Hospital Operations", "Bring departments and administrative workflows together so staff can access accurate information when it is needed." },
                new[] { "Secure and Scalable", "Role-based access and structured records support privacy, accountability, and future growth." }
            });
        }

        [HttpGet("Inventory Management")]
        public IActionResult InventoryManagement()
        {
            return WindowsDetail("Inventory Management", "Inventory management solutions", "Maintain accurate stock levels, product records, purchasing, sales, and warehouse operations with centralized inventory software.", new[]
            {
                new[] { "Product Catalog", "Manage products, variants, prices, suppliers, and categories." },
                new[] { "Stock Tracking", "Monitor available, reserved, damaged, and reorder quantities." },
                new[] { "Purchasing and Receiving", "Manage purchase orders, goods receipts, and supplier activity." },
                new[] { "Warehouse Transfers", "Track stock movement across locations with clear transaction history." },
                new[] { "Inventory Reports", "Use stock valuation, movement, and reorder reports to make decisions." }
            }, new[]
            {
                new[] { "Accurate Stock Visibility", "Centralized stock information helps teams reduce shortages, excess inventory, and manual reconciliation." },
                new[] { "Efficient Warehouse Workflows", "Purchasing, receiving, transfers, and reporting work together in one operational system." }
            });
        }

        [HttpGet("Manufacturing Management")]
        public IActionResult ManufacturingManagement()
        {
            return WindowsDetail("Manufacturing Management Software", "Manufacturing management solutions", "Plan production, manage materials, monitor work orders, and improve manufacturing efficiency with connected desktop software.", new[]
            {
                new[] { "Production Planning", "Plan production schedules around demand, capacity, and available resources." },
                new[] { "Work Orders", "Create, assign, and track manufacturing work orders from start to finish." },
                new[] { "Materials and Inventory", "Monitor raw materials, finished goods, and consumption across operations." },
                new[] { "Quality Control", "Record inspections, identify issues, and maintain consistent product quality." },
                new[] { "Operational Reports", "Measure production output, costs, downtime, and resource utilization." }
            }, new[]
            {
                new[] { "Organized Production", "Connect planning, work orders, materials, and quality checks so production teams can work from accurate information." },
                new[] { "Actionable Manufacturing Insights", "Clear operational reporting helps identify delays, waste, and opportunities for improvement." }
            });
        }
        [HttpGet("POS Software")]
        public IActionResult PosSoftware()
        {
            return WindowsDetail("POS Software", "Point of sale solutions", "Speed up point-of-sale operations with software for products, transactions, payments, inventory, and business reporting.", new[]
            {
                new[] { "Fast Checkout", "Complete sales transactions quickly with an easy-to-use interface." },
                new[] { "Product and Pricing", "Manage product catalogs, prices, taxes, and promotional discounts." },
                new[] { "Payments and Receipts", "Support payment collection and accurate receipt generation." },
                new[] { "Inventory Updates", "Keep stock quantities synchronized as sales are completed." },
                new[] { "Sales Reporting", "Understand revenue, products, transactions, and cashier performance." }
            }, new[]
            {
                new[] { "Reliable Retail Operations", "A streamlined POS reduces checkout friction and keeps sales and inventory information aligned." },
                new[] { "Ready for Multiple Workflows", "Flexible product, payment, and reporting features support different retail and service environments." }
            });
        }
        [HttpGet("School Management")]
        public IActionResult SchoolManagement()
        {
            return WindowsDetail("School Management System", "Education management systems", "Coordinate students, staff, classes, attendance, fees, examinations, and communication through one connected school management system.", new[]
            {
                new[] { "Student Records", "Maintain student profiles, enrollment details, and academic history." },
                new[] { "Classes and Attendance", "Organize classes, timetables, attendance, and daily activities." },
                new[] { "Fees and Payments", "Manage fee structures, collections, receipts, and outstanding balances." },
                new[] { "Examinations and Results", "Plan examinations and publish accurate grades and report cards." },
                new[] { "Parent and Staff Communication", "Keep families, teachers, and administrators connected with timely updates." }
            }, new[]
            {
                new[] { "One Connected School Platform", "Bring academic, administrative, and communication workflows together to reduce duplicated work." },
                new[] { "Better Information for Better Decisions", "Clear records and reports help school leaders, staff, students, and families stay informed." }
            });
        }

        [HttpGet("E-Commerce")]
        public IActionResult ECommerce()
        {
            return WindowsDetail("E-Commerce Applications", "Desktop commerce solutions", "Support connected commerce operations with dependable desktop tools for products, orders, payments, and customers.", new[]
            {
                new[] { "Commerce Operations", "Manage daily commerce workflows from one application." },
                new[] { "Order Management", "Track orders and fulfillment with greater accuracy." },
                new[] { "Payment Processing", "Support reliable and efficient payment operations." },
                new[] { "Reporting and Insights", "Turn commerce activity into useful business information." }
            }, new[]
            {
                new[] { "Connected Commerce Workflows", "Bring products, customers, orders, and payments into one consistent operational process." },
                new[] { "Built for Practical Operations", "Desktop tools provide dependable access to the information teams need to fulfill orders and serve customers." }
            });
        }

        private IActionResult WindowsDetail(string title, string subtitle, string intro, string[][] features, string[][] sections)
        {
            ViewData["DetailTitle"] = title;
            ViewData["DetailSubtitle"] = subtitle;
            ViewData["DetailIntro"] = intro;
            ViewData["DetailFeatures"] = features;
            ViewData["DetailSections"] = sections;
            return View("~/Views/Services/Windows Application/Detail.cshtml");
        }
    }
}