using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Webapp.Data;

namespace Webapp.Pages.Vehicles
{
    public class DetailsModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public DetailsModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        public MyCar MyCar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCar = await _context.MyCar
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
    }
}
