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
        [BindProperty]
        public string serverinfo { get; set; }

        [BindProperty] public string login { get; set; }
        [BindProperty] public string password { get; set; }
        public void OnGet()
        {
            this.serverinfo = "Development";
        }

        public void OnPost()
        {
            string _login = login; // this.Request.Form["login"].ToString();
            string _spwd = password; // this.Request.Form["password"].ToString();

            ViewData["status"] = "Login:" + _login + " -request is being processed.";

            //return RedirectToPage("/");
        }
    }
}
