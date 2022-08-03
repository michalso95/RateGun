using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    public class AccessLvl
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte Permissions { get; set; }

        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
