using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class GunPhoto
    {
        public Guid Id { get; set; }                //PK
        public Guid GunId { get; set; }
        public Gun Gun { get; set; }                //FK
        public string Author { get; set; }
        public string PHOTO { get; set; }           //TODO - how to store photo in DB?
                                                    //

        public GunPhoto(Gun gun, string author, string photo)
        {
            Id = Guid.NewGuid();
            GunId = gun.Id;
            Gun = gun;
            Author = author;
            PHOTO = photo;
        }
    }
}
