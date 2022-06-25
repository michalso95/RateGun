using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;

namespace RateGun.Infrastructure
{
    internal class DBContext : DbContext
    {
        public DbSet<Gun> Guns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccessLvl> AccessLvls { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}
