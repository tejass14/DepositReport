using DepositReport.Models.Controls;
using Microsoft.AspNetCore.Mvc;

namespace DepositReport.ViewComponents
{
    public class DateInputViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string id, string label, string value)
        {
            var model = new DateInputModel { Id = id, Label = label, Value = value };
            return View("DateInput", model);
        }
    }
}
