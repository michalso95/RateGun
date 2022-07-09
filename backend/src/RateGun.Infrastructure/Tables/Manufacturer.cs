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
        public string? DescrGeneral { get; set; }
        public string? DescrHistory { get; set; }
        public string? DescrCuriosities { get; set; }
        public int? EstablishYear { get; set; }
        public int? CloseYear { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }

        public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();

        public Manufacturer(string country, string location, string? descrGeneral=null, string? descrHistory = null, 
            string? descrCuriosities = null, int? establishYear = null, int? closeYear = null)
        {
            Country = country ?? throw new ArgumentNullException(nameof(country));
            Location = location ?? throw new ArgumentNullException(nameof(location));
            Id = Guid.NewGuid();
            DescrGeneral = descrGeneral;
            DescrHistory = descrHistory;
            DescrCuriosities = descrCuriosities;
            EstablishYear = establishYear;
            CloseYear = closeYear;
        }
    }
}
