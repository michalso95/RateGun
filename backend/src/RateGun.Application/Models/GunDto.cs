using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateGun.Infrastructure;

namespace RateGun.Application.Models
{
    public class GunDto
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string? Version { get; set; }
        public string Type { get; set; }
        public int? ProductionBegin { get; set; }
        public int? ProductionFinish { get; set; }
        public string? DescrGeneral { get; set; }
        public string? DescrTech { get; set; }
        public string? DescrCuriosities { get; set; }
        public string? DescrHistory { get; set; }
        public string? Bibliography { get; set; }

        public string ManufacturerName { get; set; }
        public List<string>? GunPlantsNames { get; set; }
        public List<int>? MagazineCapacities { get; set; }
        public List<string>? BulletCals { get; set; }
    }
}