using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateGun.Infrastructure;

namespace RateGun.Application.Models
{
    public class UpdateGunDto
    {
        public string? Model { get; set; }
        public string? Version { get; set; }
        public string? Type { get; set; }
        public string? ManufacturerName { get; set; }
        public string? GunPlantName { get; set; }
        public int? ProductionBegin { get; set; }
        public int? ProductionFinish { get; set; }
        public List<int>? MagazineCapacities { get; set; }
        public List<string>? BulletCals { get; set; }
        public string? DescrGeneral { get; set; }
        public string? DescrTech { get; set; }
        public string? DescrCuriosities { get; set; }
        public string? DescrHistory { get; set; }
        public string? Bibliography { get; set; }

        //authors?
    }
}
