using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class MagazineCapacity
    {
        public Guid Id { get; set; }                //PK
        public int Capacity { get; set; }

        public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();
    }
}
