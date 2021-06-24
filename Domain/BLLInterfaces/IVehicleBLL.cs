using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;

namespace Domain.BLLInterfaces
{
    public interface IVehicleBLL
    {
        IEnumerable<MyCar> getMyCarList();
        MyCar getMyCar(int id);
        bool isCarExist(int id);
        void UpdateCar(MyCar mycar);
        int CommitChanges();

        IEnumerable<MyCarDrivetrain> Drivetrains { get; }
        IEnumerable<MyCarModel> CarModels { get; }
        IEnumerable<MyCarFuel> CarFuels { get; }
        IEnumerable<MyCarTransmission> CarTransmissions { get; }
        IEnumerable<MyAccount> MyAccounts { get; }

    }
}
