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

namespace MyCarCare.Pages.Garage.Movement
{
    public class EditModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public EditModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyCarTrxGarage MyCarTrxGarage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarTrxGarage = await _context.MyCarTrxGarages
                .Include(m => m.MyCarTrx)
                .Include(m => m.MyGarage).FirstOrDefaultAsync(m => m.Id == id);

            if (MyCarTrxGarage == null)
            {
                return NotFound();
            }
           ViewData["MyCarTrxId"] = new SelectList(_context.MyCarTrxes, "Id", "Id");
           ViewData["MyGarageId"] = new SelectList(_context.MyGarages, "Id", "Id");
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

            _context.Attach(MyCarTrxGarage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyCarTrxGarageExists(MyCarTrxGarage.Id))
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

        private bool MyCarTrxGarageExists(int id)
        {
            return _context.MyCarTrxGarages.Any(e => e.Id == id);
        }
    }
}
