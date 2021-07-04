using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.VehicleControl.Reminder
{
    public class EditModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public EditModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["MyCarId"] = new SelectList(_context.MyCars, "Id", "Id");
           ViewData["MyReminderTypeId"] = new SelectList(_context.MyReminderTypes, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyCarReminder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyCarReminderExists(MyCarReminder.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyCarReminderExists(int id)
        {
            return _context.MyCarReminders.Any(e => e.Id == id);
        }
    }
}
