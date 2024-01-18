using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class City : EntityBase
    {
        public Guid CountryId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }

        public Country Country { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
