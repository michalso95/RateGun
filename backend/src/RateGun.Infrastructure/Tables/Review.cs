using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class Review
    {
        public Guid Id { get; set; }                    //PK
        public Guid UserId { get; set; }
        public User User { get; set; }                  //FK
        public Guid GunId { get; set; }
        public Gun Gun { get; set; }                    //FK
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
        public int Visibility { get; set; }             //0 not visible; 1 visible; 2 shadowban
        public int NonCompilancePoints { get; set; }
        public int Points { get; set; }                 //Number of likes
        public DateTime PublicationDate { get; set; }

        public Review(User user, Gun gun, decimal rateGeneral, string descrRate, int visibility, 
            decimal? rateAccuarcy = null, decimal? rateDefaultAiming = null, decimal? rateFailureFree = null, 
            decimal? rateMaterialQuality = null, decimal? rateLook = null, decimal? rateErgonomic = null, 
            decimal? ratePartsAddsAvailability = null, decimal? rateModifiable = null)
        {
            Id = Guid.NewGuid();
            UserId = user.Id;
            User = user;
            GunId = gun.Id;
            Gun = gun;
            RateGeneral = rateGeneral;
            RateAccuarcy = rateAccuarcy;
            RateDefaultAiming = rateDefaultAiming;
            RateFailureFree = rateFailureFree;
            RateMaterialQuality = rateMaterialQuality;
            RateLook = rateLook;
            RateErgonomic = rateErgonomic;
            RatePartsAddsAvailability = ratePartsAddsAvailability;
            RateModifiable = rateModifiable;
            DescrRate = descrRate;
            Visibility = visibility;
            NonCompilancePoints = 0;
            Points = 0;
            PublicationDate = DateTime.UtcNow;
        }
        //TODO how to add multiphotos to the Review


    }
}
