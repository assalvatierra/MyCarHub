using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Vahicle
{
    public class EditModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public EditModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyCar MyCar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCar = await _context.MyCars
                .Include(m => m.MyAccount)
                .Include(m => m.MyCarDrivetrain)
                .Include(m => m.MyCarFuel)
                .Include(m => m.MyCarModel)
                .Include(m => m.MyCarTransmission).FirstOrDefaultAsync(m => m.Id == id);

            if (MyCar == null)
            {
                return NotFound();
            }
           ViewData["MyAccountId"] = new SelectList(_context.MyAccounts, "Id", "Id");
           ViewData["MyCarDrivetrainId"] = new SelectList(_context.MyCarDrivetrains, "Id", "Id");
           ViewData["MyCarFuelId"] = new SelectList(_context.MyCarFuels, "Id", "Id");
           ViewData["MyCarModelId"] = new SelectList(_context.MyCarModels, "Id", "Id");
           ViewData["MyCarTransmissionId"] = new SelectList(_context.MyCarTransmissions, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyCarExists(MyCar.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyCarExists(int id)
        {
            return _context.MyCars.Any(e => e.Id == id);
        }
    }
}
