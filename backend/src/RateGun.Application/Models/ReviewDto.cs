using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateGun.Infrastructure;

namespace RateGun.Application.Models
{
    public class ReviewDto
    {
        public Guid Id { get; set; }                    
        public decimal RateGeneral { get; set; }
        public decimal? RateAccuarcy { get; set; }
        public decimal? RateDefaultAiming { get; set; }
        public decimal? RateFailureFree { get; set; }
        public decimal? RateMaterialQuality { get; set; }
        public decimal? RateLook { get; set; }
        public decimal? RateErgonomic { get; set; }
        public decimal? RatePartsAddsAvailability { get; set; }
        public decimal? RateModifiable { get; set; }
        public string DescrRate { get; set; }
        public int Points { get; set; }                 //Number of likes
        public DateTime PublicationDate { get; set; }
        
        public string UserName { get; set; } 
        public string GunName { get; set; }
    }
}
