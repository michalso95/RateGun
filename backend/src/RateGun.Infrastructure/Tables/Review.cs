using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class Review
    {
        public Guid Id { get; set; }                    //PK
        public Guid UserId { get; set; }
        public User User { get; set; }                  //FK
        public Guid GunId { get; set; }
        public Gun Gun { get; set; }                    //FK
        public decimal RateGeneral {get;set;}
        public decimal RateAccuarcy {get;set;}
        public decimal RateDefaultAiming {get;set;}
        public decimal RateFailureFree {get;set;}
        public decimal RateMaterialQuality {get;set;}
        public decimal RateLook {get;set;}
        public decimal RateErgonomic { get; set; }
        public decimal RatePartsAddsAvailability { get; set; }
        public decimal RateModifiable { get; set; }
        public string DescrRate {get;set; }
        public int Visibility { get; set; }             //0 not visible; 1 visible; 2 shadowban
        public int NonCompilancePoints { get; set; }
        public int Points { get; set; }                 //Number of likes
        public DateOnly PublicationDate { get; set; }
        //TODO how to add multiphotos to the Review
    }
}
