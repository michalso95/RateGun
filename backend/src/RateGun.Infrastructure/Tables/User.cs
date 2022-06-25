using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class User
    {
        public Guid Id { get; set; }                //PK
        public string Name { get; set; }
        public Guid? AccessLvlId { get; set; }
        public AccessLvl AccessLvl { get; set; }    //FK
        public int Exp { get; set; }
        public int Lvl { get; set; }
        public string SignatureFooter { get; set; }
        public string Avatar { get; set; }          //photo

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
