using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Vahicle
{
    public class DeleteModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DeleteModel(DataLayer.MyCarDBContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCar = await _context.MyCars.FindAsync(id);

            if (MyCar != null)
            {
                _context.MyCars.Remove(MyCar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
