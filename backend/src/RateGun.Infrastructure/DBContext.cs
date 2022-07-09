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
        //entities
        public DbSet<Gun> Guns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccessLvl> AccessLvls { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MagazineCapacity> MagazineCapacities { get; set; }
        public DbSet<BulletCal> BulletCals { get; set; }
        public DbSet<GunPlant> GunPlants { get; set; }

        //private variables
        private readonly string _connectionString;


        public DBContext()
        {
            _connectionString = "Filename=DBRateGunMain.db";
        }

        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (String.IsNullOrEmpty(_connectionString))
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


    }
}
