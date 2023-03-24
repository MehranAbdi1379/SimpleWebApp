using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Domain;
using SimpleWebApp.UI.DTO;
using SimpleWebApp.Services;

namespace SimpleWebApp.UI.Pages.WriterPages
{
    public class WriterMainPageModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string PassWord { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }


        public void OnGet()
        {
            
        }
    }
}
