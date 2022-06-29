using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class BulletCal
    {
        public Guid Id { get; set; }                //PK
        public string Name { get; set; }
        public string Descr { get; set; }
        public string Inventor { get; set; }
        public string InventorCountry { get; set; }
        public int YearInvented { get; set; }
        public int YearProductionStart { get; set; }
        public int YearProductionEnd { get; set; }
        public bool IsProduce { get; set; }

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
