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
    public class IndexModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public IndexModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public IList<MyCarTrxGarage> MyCarTrxGarage { get;set; }

        public async Task OnGetAsync()
        {
            MyCarTrxGarage = await _context.MyCarTrxGarages
                .Include(m => m.MyCarTrx)
                .Include(m => m.MyGarage).ToListAsync();
        }
    }
}
