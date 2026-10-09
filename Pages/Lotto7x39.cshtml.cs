using LotteryApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LotteryApp.Pages;

public class Lotto7x39Model : PageModel
{
    public List<int> Numbers { get; set; } = new();

    public void OnGet()
    {
        Numbers = GenerateNumbers();
    }

    private List<int> GenerateNumbers()
    {
        return LotteryGenerator.GenerateNumbers(7, 1, 39);
    }
}