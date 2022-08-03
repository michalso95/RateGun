using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class Manufacturer
    {
        public Guid Id { get; set; }                  //PK
        public string Name { get; set; }
        public string? DescrGeneral { get; set; }
        public string? DescrHistory { get; set; }
        public string? DescrCuriosities { get; set; }
        public int? EstablishYear { get; set; }
        public int? CloseYear { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }

        public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();
    }
}
