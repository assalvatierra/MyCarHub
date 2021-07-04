﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public DetailsModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public MyCarReminder MyCarReminder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCarReminder = await _context.MyCarReminders
                .Include(m => m.MyCar)
                .Include(m => m.MyReminderType).FirstOrDefaultAsync(m => m.Id == id);

            if (MyCarReminder == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
