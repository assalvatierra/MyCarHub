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

        int CommitChanges();
    }
}
