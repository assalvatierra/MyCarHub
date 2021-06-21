using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BLLInterfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Service.Tests
{
    public class MockBLLVehicles : IVehicleBLL
    {

        private IMyCarRepository MyCarRepo;
        public MockBLLVehicles(object _context, IMyCarRepository mycarrepo)
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
