﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class Gun

    {
        public Guid Id { get; set; }                  //PK
        public string Model { get; set; }
        public string? Version { get; set; }
        public string Type { get; set; }
        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }     //FK
        public Guid? GunPlantId { get; set; }
        public GunPlant? GunPlant { get; set; }
        public int? ProductionBegin { get; set; }
        public int? ProductionFinish { get; set; }
        public Guid? MagazineCapacityId { get; set; }
        public MagazineCapacity? MagazineCapacity { get; set; }
        public Guid BulletCalId { get; set; }
        public BulletCal BulletCal { get; set; }
        public string DescrGeneral { get; set; }
        public string? DescrTech { get; set; }
        public string? DescrCuriosities { get; set; }
        public string? DescrHistory { get; set; }
        public string? Bibliography { get; set; }

        public ICollection<GunPhoto> GunPhotos { get; set; } = new HashSet<GunPhoto>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        public Gun(string model, string type, Manufacturer manufacturer, BulletCal bulletCal, string descrGeneral, 
            string? version = null, GunPlant? gunPlant = null,int? productionBegin = null, int? productionFinish = null, 
            MagazineCapacity? magazineCapacity = null, string? descrTech = null, string? descrCuriosities = null, 
            string? descrHistory = null, string? bibliography = null)
        {
            Id = Guid.NewGuid();
            Model = model;
            Version = version;
            Type = type;
            ManufacturerId = manufacturer.Id;
            Manufacturer = manufacturer;
            GunPlantId = gunPlant?.Id;
            GunPlant = gunPlant;
            ProductionBegin = productionBegin;
            ProductionFinish = productionFinish;
            MagazineCapacityId = magazineCapacity?.Id;
            MagazineCapacity = magazineCapacity;
            BulletCalId = bulletCal.Id;
            BulletCal = bulletCal;
            DescrGeneral = descrGeneral;
            DescrTech = descrTech;
            DescrCuriosities = descrCuriosities;
            DescrHistory = descrHistory;
            Bibliography = bibliography;
        }
    }
}
