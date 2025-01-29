#region usings
using Microsoft.AspNetCore.Mvc;
#endregion

namespace DepositReport.Controllers
{
    public class DepositReportController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateReport()
        {
            return RedirectToAction("Index");
        }
    }
}
