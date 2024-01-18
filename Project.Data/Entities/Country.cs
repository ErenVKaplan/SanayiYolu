using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Country : EntityBase
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
