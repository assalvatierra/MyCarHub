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
    public class DetailsModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DetailsModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

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
    }
}
