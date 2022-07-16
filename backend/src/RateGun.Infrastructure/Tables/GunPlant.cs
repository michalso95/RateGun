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

        public GunPlant(string name, string location, int yearEstablish, int? yearClose=null, 
            bool? isRunning = null, string? descr = null)
        {
            Id = Guid.NewGuid();
            Name = name;
            Descr = descr;
            Location = location;
            YearEstablish = yearEstablish;
            YearClose = yearClose;
            IsRunning = isRunning;
        }
    }
}
