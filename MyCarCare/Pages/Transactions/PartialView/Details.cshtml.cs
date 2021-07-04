using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Transactions.PartialView
{
    public class DetailsModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DetailsModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

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
    }
}
