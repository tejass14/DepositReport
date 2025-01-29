#region usings
using DepositReport.Models.Controls;
using Microsoft.AspNetCore.Mvc; 
#endregion

namespace DepositReport.ViewComponents
{
    public class TextInputViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string id, string label, string value, int? length)
        {
            var model = new TextInputModel { Id = id, Label = label, Value = value, Length = length };
            return View("TextInput", model);
        }
    }
}
