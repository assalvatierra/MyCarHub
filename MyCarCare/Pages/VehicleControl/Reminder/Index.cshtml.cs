using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.VehicleControl.Reminder
{
    public class IndexModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public IndexModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public IList<MyCarReminder> MyCarReminder { get;set; }

        public async Task OnGetAsync()
        {
            MyCarReminder = await _context.MyCarReminders
                .Include(m => m.MyCar)
                .Include(m => m.MyReminderType).ToListAsync();
        }
    }
}
