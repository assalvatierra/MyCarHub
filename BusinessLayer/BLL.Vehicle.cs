using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BLLInterfaces;
using Domain.Entities;
using Domain.Interfaces;
using DataLayer.EFCore;
using DataLayer.EFCore.Repositories;


namespace BusinessLayer
{
    public class BLLVehicles : IVehicleBLL
    {
        protected MyCarDBContext context;
        public IMyCarRepository MyCars;

        public BLLVehicles(MyCarDBContext _context, IMyCarRepository mycarrepo)
        {
            this.context = _context;
            this.MyCars = mycarrepo;
        }


        

        public int CommitChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MyCar> getMyCarList()
        {
            return this.MyCars.GetAll();
        }


    }
}
