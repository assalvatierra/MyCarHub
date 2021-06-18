using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Service.Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext (DbContextOptions<ServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Entities.MyCar> MyCar { get; set; }
    }
}
