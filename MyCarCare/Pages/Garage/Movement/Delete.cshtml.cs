using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Garage.Movement
{
    public class DeleteModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DeleteModel(DataLayer.MyCarDBContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarTrxGarage = await _context.MyCarTrxGarages.FindAsync(id);

            if (MyCarTrxGarage != null)
            {
                _context.MyCarTrxGarages.Remove(MyCarTrxGarage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
