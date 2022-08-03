using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RateGun.Application.Models
{
    public class CreateReviewDto
    {
        [Required]
        [Range(0, 10)]
        public decimal RateGeneral { get; set; }
        [Range(0, 10)]
        public decimal? RateAccuarcy { get; set; }
        [Range(0, 10)]
        public decimal? RateDefaultAiming { get; set; }
        [Range(0, 10)]
        public decimal? RateFailureFree { get; set; }
        [Range(0, 10)]
        public decimal? RateMaterialQuality { get; set; }
        [Range(0, 10)]
        public decimal? RateLook { get; set; }
        [Range(0, 10)]
        public decimal? RateErgonomic { get; set; }
        [Range(0, 10)]
        public decimal? RatePartsAddsAvailability { get; set; }
        [Range(0, 10)]
        public decimal? RateModifiable { get; set; }
        [Required]
        [MaxLength(5000)]
        public string DescrRate { get; set; }
        [Required]
        public Guid GunId { get; set; }
        //[Required]                //or info from backend?
        public Guid UserId { get; set; }              //Frontend or Backend?
    }
}
