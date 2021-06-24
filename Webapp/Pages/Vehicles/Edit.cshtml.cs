using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.BLLInterfaces;
using Webapp.Data;

namespace Webapp.Pages.Vehicles
{
    public class EditModel : PageModel
    {
        //private readonly Webapp.Data.WebappContext _context;
        private Domain.BLLInterfaces.IVehicleBLL vehicle;

        public EditModel(IVehicleBLL _vehicle)
        {
            this.vehicle = _vehicle;
        }

        [BindProperty]
        public MyCar MyCar { get; set; }

        public IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyCar = vehicle.getMyCar( (id==null? 0: id.Value) );

            if (MyCar == null)
            {
                return NotFound();
            }

            //           ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id");
                       ViewData["MyCarDrivetrainId"] = new SelectList(this.vehicle.Drivetrains, "Id", "Drivetrain");
            //           ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id");
            //           ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id");
            //           ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id");
            
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Attach(MyCar).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MyCarExists(MyCar.Id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToPage("./Index");
        //}

        //private bool MyCarExists(int id)
        //{
        //    return _context.MyCar.Any(e => e.Id == id);
        //}
    }
}
