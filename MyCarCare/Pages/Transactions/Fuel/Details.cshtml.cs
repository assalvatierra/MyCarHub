using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Transactions.Fuel
{
    public class DetailsModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DetailsModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public MyCarFuel MyCarFuel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarFuel = await _context.MyCarFuels.FirstOrDefaultAsync(m => m.Id == id);

            if (MyCarFuel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
