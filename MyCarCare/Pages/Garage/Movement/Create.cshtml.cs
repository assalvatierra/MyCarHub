using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Garage.Movement
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
        ViewData["MyCarTrxId"] = new SelectList(_context.MyCarTrxes, "Id", "Id");
        ViewData["MyGarageId"] = new SelectList(_context.MyGarages, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public MyCarTrxGarage MyCarTrxGarage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyCarTrxGarages.Add(MyCarTrxGarage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
