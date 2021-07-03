using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Main.Driver
{
    public class IndexModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public IndexModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public IList<MyDriver> MyDriver { get;set; }

        public async Task OnGetAsync()
        {
            MyDriver = await _context.MyDrivers
                .Include(m => m.MyAccount).ToListAsync();
        }
    }
}
