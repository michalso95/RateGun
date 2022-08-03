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
    public class RateGunDBContext : DbContext
    {
        //entities
        public DbSet<Gun> Guns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccessLvl> AccessLvls { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MagazineCapacity> MagazineCapacities { get; set; }
        public DbSet<BulletCal> BulletCals { get; set; }
        public DbSet<GunPlant> GunPlants { get; set; }
        public DbSet<GunPhoto> GunPhotos { get; set; }

        //private variables
        private readonly string _connectionString;

        public RateGunDBContext()
        {
            _connectionString = "Filename=DBRateGunMain.db";
        }

        public RateGunDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {

            }
            else
            {
                optionsBuilder.UseSqlite(_connectionString, options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gun>()
                .Property(r => r.Model)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<AccessLvl>()
                .Property(d => d.Name)
                .IsRequired();

        }


    }
}
