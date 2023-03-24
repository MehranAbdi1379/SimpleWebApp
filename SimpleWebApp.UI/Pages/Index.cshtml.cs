using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.UI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPostSignIn()
    {
        return RedirectToPage("Signing pages/SignInPage");
    }
    
    public IActionResult OnPostSignUp()
    {
        return RedirectToPage("Signing pages/SignUpPage");
    }
}
