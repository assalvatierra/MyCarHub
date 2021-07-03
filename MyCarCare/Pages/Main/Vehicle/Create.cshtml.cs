using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Vahicle
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
        ViewData["MyCarDrivetrainId"] = new SelectList(_context.MyCarDrivetrains, "Id", "Id");
        ViewData["MyCarFuelId"] = new SelectList(_context.MyCarFuels, "Id", "Id");
        ViewData["MyCarModelId"] = new SelectList(_context.MyCarModels, "Id", "Id");
        ViewData["MyCarTransmissionId"] = new SelectList(_context.MyCarTransmissions, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public MyCar MyCar { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyCars.Add(MyCar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
