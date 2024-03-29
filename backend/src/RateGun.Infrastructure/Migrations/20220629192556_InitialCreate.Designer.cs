﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RateGun.Infrastructure;

#nullable disable

namespace RateGun.Infrastructure.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220629192556_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("RateGun.Infrastructure.AccessLvl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Permissions")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AccessLvls");
                });

            modelBuilder.Entity("RateGun.Infrastructure.BulletCal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Inventor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InventorCountry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsProduce")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearInvented")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearProductionEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearProductionStart")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BulletCals");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Gun", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bibliography")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BulletCalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrCuriosities")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrGeneral")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrHistory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrTech")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GunPlantId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MagazineCapacityId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ManufacturerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductionBegin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductionFinish")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BulletCalId");

                    b.HasIndex("GunPlantId");

                    b.HasIndex("MagazineCapacityId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Guns");
                });

            modelBuilder.Entity("RateGun.Infrastructure.GunPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GunId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PHOTO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GunId");

                    b.ToTable("GunPhoto");
                });

            modelBuilder.Entity("RateGun.Infrastructure.GunPlant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRunning")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearClose")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearEstablish")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("GunPlants");
                });

            modelBuilder.Entity("RateGun.Infrastructure.MagazineCapacity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MagazineCapacities");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CloseYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrCuriosities")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrGeneral")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrHistory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EstablishYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BulletCalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrRate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GunId")
                        .HasColumnType("TEXT");

                    b.Property<int>("NonCompilancePoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("PublicationDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateAccuarcy")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateDefaultAiming")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateErgonomic")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateFailureFree")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateGeneral")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateLook")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateMaterialQuality")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RateModifiable")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RatePartsAddsAvailability")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Visibility")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BulletCalId");

                    b.HasIndex("GunId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RateGun.Infrastructure.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AccessLvlId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Exp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lvl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SignatureFooter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccessLvlId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Gun", b =>
                {
                    b.HasOne("RateGun.Infrastructure.BulletCal", "BulletCal")
                        .WithMany()
                        .HasForeignKey("BulletCalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateGun.Infrastructure.GunPlant", "GunPlant")
                        .WithMany("Guns")
                        .HasForeignKey("GunPlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateGun.Infrastructure.MagazineCapacity", "MagazineCapacity")
                        .WithMany("Guns")
                        .HasForeignKey("MagazineCapacityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateGun.Infrastructure.Manufacturer", "Manufacturer")
                        .WithMany("Guns")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BulletCal");

                    b.Navigation("GunPlant");

                    b.Navigation("MagazineCapacity");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("RateGun.Infrastructure.GunPhoto", b =>
                {
                    b.HasOne("RateGun.Infrastructure.Gun", "Gun")
                        .WithMany("GunPhotos")
                        .HasForeignKey("GunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gun");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Review", b =>
                {
                    b.HasOne("RateGun.Infrastructure.BulletCal", null)
                        .WithMany("Reviews")
                        .HasForeignKey("BulletCalId");

                    b.HasOne("RateGun.Infrastructure.Gun", "Gun")
                        .WithMany("Reviews")
                        .HasForeignKey("GunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateGun.Infrastructure.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gun");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RateGun.Infrastructure.User", b =>
                {
                    b.HasOne("RateGun.Infrastructure.AccessLvl", "AccessLvl")
                        .WithMany("Users")
                        .HasForeignKey("AccessLvlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessLvl");
                });

            modelBuilder.Entity("RateGun.Infrastructure.AccessLvl", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RateGun.Infrastructure.BulletCal", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Gun", b =>
                {
                    b.Navigation("GunPhotos");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("RateGun.Infrastructure.GunPlant", b =>
                {
                    b.Navigation("Guns");
                });

            modelBuilder.Entity("RateGun.Infrastructure.MagazineCapacity", b =>
                {
                    b.Navigation("Guns");
                });

            modelBuilder.Entity("RateGun.Infrastructure.Manufacturer", b =>
                {
                    b.Navigation("Guns");
                });

            modelBuilder.Entity("RateGun.Infrastructure.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
