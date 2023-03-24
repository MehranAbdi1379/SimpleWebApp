using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Services;

namespace SimpleWebApp.UI.Pages.Signing_pages
{
    public class SignUpPageModel : PageModel
    {
        private IGlobalServices GlobalServices;

        public SignUpPageModel(IGlobalServices globalServices)
        {
            this.GlobalServices = globalServices;
        }

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string PassWord { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty(SupportsGet = true)]
        public DateTime BirthDate { get; set; }

        [BindProperty]
        public bool ReturnedToPage { get; set; } = false;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (GlobalServices.SignUp(FirstName,LastName,UserName,PassWord,BirthDate))
                return RedirectToPage("../WriterPages/WriterMainPage", new { UserName });
            else
                return RedirectToPage(new { ReturnedToPage = true });
        }
    }
}