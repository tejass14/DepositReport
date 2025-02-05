
#region usings
using DepositReport.Models.Controls;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace DepositReport.ViewComponents
{
    public class NumberInputViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string id, string label, int value)
        {
            var model = new NumberInputModel { Id = id, Label = label, Value = value };
            return View("NumberInput", model);
        }
    }
}
