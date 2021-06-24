using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BLLInterfaces;
using Domain.Entities;
using Domain.Interfaces;
using DataLayer;
using DataLayer.Repositories;


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
            return this.context.SaveChanges();
        }

        public IEnumerable<MyCar> getMyCarList()
        {
            return this.MyCars.GetAll();
        }

        public MyCar getMyCar(int id)
        {
            return this.MyCars.GetById(id);
        }

        public bool isCarExist(int id)
        {
            return this.context.MyCars.Any(e => e.Id == id);
 //           return this.MyCars.isExist(id);
        }
        public void UpdateCar(MyCar mycar)
        {
            this.context.Update<MyCar>(mycar);
        }

        public IEnumerable<MyCarDrivetrain> Drivetrains {
            get
            {
                return this.context.MyCarDrivetrains;
            }
        }
        public IEnumerable<MyCarModel> CarModels
        {
            get
            {
                return this.context.MyCarModels;
            }
        }
        public IEnumerable<MyCarFuel> CarFuels
        {
            get
            {
                return this.context.MyCarFuels;
            }
        }
        public IEnumerable<MyCarTransmission> CarTransmissions
        {
            get
            {
                return this.context.MyCarTransmissions;
            }
        }

        public IEnumerable<MyAccount> MyAccounts {
            get
            {
                return this.context.MyAccounts;
            }
        }

    }
}
