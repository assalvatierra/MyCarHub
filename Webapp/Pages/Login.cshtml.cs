using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages
{
    public class LoginModel : PageModel
    {
        public string serverinfo;
        public void OnGet()
        {
            this.serverinfo = "Development";
        }

        public IActionResult OnPost()
        {
            string login = this.Request.Form["login"].ToString();
            string spwd = this.Request.Form["password"].ToString();

            return RedirectToPage("/");
        }
    }
}
