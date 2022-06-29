using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class Gun

    {
        public Guid Id { get; set; }                  //PK
        public string Model { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }     //FK
        public Guid GunPlantId { get; set; }
        public GunPlant GunPlant { get; set; }
        public int ProductionBegin { get; set; }
        public int ProductionFinish { get; set; }
        public Guid MagazineCapacityId { get; set; }
        public MagazineCapacity MagazineCapacity { get; set; }
        public Guid BulletCalId { get; set; }
        public BulletCal BulletCal {get;set;}
        public string DescrGeneral { get; set; }
        public string DescrTech { get; set; }
        public string DescrCuriosities { get; set; }
        public string DescrHistory { get; set; }
        public string Bibliography { get; set; }

        public ICollection<GunPhoto> GunPhotos { get; set; } = new HashSet<GunPhoto>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
