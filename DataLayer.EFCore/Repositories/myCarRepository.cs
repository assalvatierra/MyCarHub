using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using DataLayer.EFCore;

namespace DataLayer.EFCore.Repositories
{
    public class myCarRepository: GenericRepository<MyCar>, IMyCarRepository
    {
        public myCarRepository(MyCarDBContext context) : base(context)
        { }
    }
}
