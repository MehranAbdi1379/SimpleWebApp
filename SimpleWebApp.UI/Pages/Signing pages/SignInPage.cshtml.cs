using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Services;

namespace SimpleWebApp.UI.Pages.Signing_pages
{
    public class SignInPageModel : PageModel
    {
        private IGlobalServices GlobalServices;

        public SignInPageModel(IGlobalServices globalServices)
        {
            this.GlobalServices = globalServices;
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string PassWord { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ReturnedToPage { get; set; } = false;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (GlobalServices.SignIn(UserName, PassWord))
                return RedirectToPage("../WriterPages/WriterMainPage", new { UserName });
            else
                return RedirectToPage(new {ReturnedToPage = true});
            
        }
    }
}
