using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Main.Garage
{
    public class CreateModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public CreateModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MyAccountId"] = new SelectList(_context.MyAccounts, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public MyGarage MyGarage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyGarages.Add(MyGarage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
