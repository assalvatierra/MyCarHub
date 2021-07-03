using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Main.Login
{
    public class DetailsModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DetailsModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public MySupportLogin MySupportLogin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MySupportLogin = await _context.MySupportLogins
                .Include(m => m.MyAccount).FirstOrDefaultAsync(m => m.Id == id);

            if (MySupportLogin == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
