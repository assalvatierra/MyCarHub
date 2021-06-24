using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities;
using Webapp.Data;

namespace Webapp.Pages.Vehicles
{
    public class CreateModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public CreateModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id");
        ViewData["MyCarDrivetrainId"] = new SelectList(_context.Set<MyCarDrivetrain>(), "Id", "Id");
        ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id");
        ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id");
        ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id");
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

            _context.MyCar.Add(MyCar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
