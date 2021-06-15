using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.BLLInterfaces
{
    public interface IVehicleBLL
    {
        IMyCarRepository MyCars { get; }

        int CommitChanges();
    }
}
