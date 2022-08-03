using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class GunPlant
    {
        public Guid Id { get; set; }                //PK
        public string Name { get; set; }
        public string? Descr { get; set; }
        public string Location { get; set; }
        public int YearEstablish { get; set; }
        public int? YearClose { get; set; }
        public bool? IsRunning { get; set; }

        public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();
    }
}
