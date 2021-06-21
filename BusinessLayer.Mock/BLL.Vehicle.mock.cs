using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BLLInterfaces;
using Domain.Entities;
using Domain.Interfaces;
using Mock.DataLayer;


namespace Mock.BuinessLayer
{
    public class BLLVehicles : IVehicleBLL
    {

        private IMyCarRepository MyCarRepo;
        public BLLVehicles(object _context, IMyCarRepository mycarrepo)
        {
            //this.context = _context;
            this.MyCarRepo = mycarrepo;
        }


        

        public int CommitChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MyCar> getMyCarList()
        {
            return this.MyCarRepo.GetAll();
        }

        public MyCar getMyCar(int id)
        {
            return this.MyCarRepo.GetById(id);
        }


    }
}
