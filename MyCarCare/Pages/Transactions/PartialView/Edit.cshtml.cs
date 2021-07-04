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

namespace MyCarCare.Pages.Transactions.PartialView
{
    public class EditModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public EditModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyCarTrx MyCarTrx { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarTrx = await _context.MyCarTrxes
                .Include(m => m.MyCar).FirstOrDefaultAsync(m => m.Id == id);

            if (MyCarTrx == null)
            {
                return NotFound();
            }
           ViewData["MyCarId"] = new SelectList(_context.MyCars, "Id", "Id");
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

            _context.Attach(MyCarTrx).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyCarTrxExists(MyCarTrx.Id))
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

        private bool MyCarTrxExists(int id)
        {
            return _context.MyCarTrxes.Any(e => e.Id == id);
        }
    }
}
