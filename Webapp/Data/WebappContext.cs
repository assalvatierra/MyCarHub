using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Webapp.Data
{
    public class WebappContext : DbContext
    {
        public WebappContext (DbContextOptions<WebappContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Entities.MyCar> MyCar { get; set; }
    }
}
