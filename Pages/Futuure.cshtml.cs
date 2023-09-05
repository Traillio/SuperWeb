using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperWeb.Models;

namespace SuperWeb.Pages
{
    public class FutureValueModel : PageModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }

        public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
    }
}