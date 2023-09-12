using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChineseWebAPP.Models;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Year { get; set; }

    [TempData]
    public string ZodiacSign { get; set; }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            ZodiacSign = ZodiacUtils.GetZodiac(Year).ToLower();
        }
        return Page();
    }
}
