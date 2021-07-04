using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Transactions
{
    public class DeleteModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DeleteModel(DataLayer.MyCarDBContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarTrx = await _context.MyCarTrxes.FindAsync(id);

            if (MyCarTrx != null)
            {
                _context.MyCarTrxes.Remove(MyCarTrx);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
