
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.BLLInterfaces;
using Webapp.Data;

namespace Webapp.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        //private readonly Webapp.Data.WebappContext _context;
        private readonly IVehicleBLL vehicle;

        public IndexModel(IVehicleBLL _vehicle)
        {
            this.vehicle = _vehicle;
        }

        public IList<MyCar> MyCar { get;set; }

        public void OnGet()
        {
            MyCar = (IList < MyCar > ) vehicle.getMyCarList();
        }

        //public async Task OnGetAsync()
        //{
        //    MyCar = await _context.MyCar
        //        .Include(m => m.MyAccount)
        //        .Include(m => m.MyCarDrivetrain)
        //        .Include(m => m.MyCarFuel)
        //        .Include(m => m.MyCarModel)
        //        .Include(m => m.MyCarTransmission).ToListAsync();
        //}
    }
}
