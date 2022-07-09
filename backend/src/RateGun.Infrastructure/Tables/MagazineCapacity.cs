using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class MagazineCapacity
    {
        public Guid Id { get; set; }                //PK
        public int Capacity { get; set; }

        public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();

        public MagazineCapacity(int capacity)
        {
            Id = Guid.NewGuid();
            Capacity = capacity;
        }
    }
}
