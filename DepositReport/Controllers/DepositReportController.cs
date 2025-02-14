#region usings

using DepositReport.Core.Managers;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace DepositReport.Controllers
{
    public class DepositReportController : Controller
    {
        private readonly IDepositReportManager _depositReportManager;

        public DepositReportController(IDepositReportManager depositReportManager)
        {
            _depositReportManager = depositReportManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateReport()
        {
            _depositReportManager.GenerateCaller();
            return RedirectToAction("Index");
        }
    }
}
