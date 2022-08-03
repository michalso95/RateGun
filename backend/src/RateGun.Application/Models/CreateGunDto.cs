using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RateGun.Infrastructure;

namespace RateGun.Application.Models
{
    public class CreateGunDto
    {
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        [Required]
        [MaxLength(100)]
        public string ManufacturerName { get; set; }  //FK

        [MaxLength(50)]
        public string? Version { get; set; }
        public int? ProductionBegin { get; set; }
        public int? ProductionFinish { get; set; }
        [MaxLength(100000)]
        public string? DescrGeneral { get; set; }
        [MaxLength(100000)]
        public string? DescrTech { get; set; }
        [MaxLength(100000)]
        public string? DescrCuriosities { get; set; }
        [MaxLength(100000)]
        public string? DescrHistory { get; set; }
        [MaxLength(100000)]
        public string? Bibliography { get; set; }

        [MaxLength(150)]
        public string? GunPlantName { get; set; }
        
        public List<int>? MagazineCapacities { get; set; }
        
        public List<string>? BulletCals { get; set; }

    }
}