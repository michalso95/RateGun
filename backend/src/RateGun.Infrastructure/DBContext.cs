using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;

namespace RateGun.Infrastructure
{
    internal class DBContext : DbContext
    {
        public DBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=DBRateGunMain.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Map table names
            //modelBuilder.Entity<Blog>().ToTable("Blogs", "test");
            //modelBuilder.Entity<Blog>(entity =>
            //{
            //    entity.HasKey(e => e.BlogId);
            //    entity.HasIndex(e => e.Title).IsUnique();
            //    entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //});
            //base.OnModelCreating(modelBuilder);
        }

        //entities
        public DbSet<Gun> Guns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccessLvl> AccessLvls { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MagazineCapacity> MagazineCapacities { get; set; }
        public DbSet<BulletCal> BulletCals { get; set; }
        public DbSet<GunPlant> GunPlants { get; set; }

    }
}
