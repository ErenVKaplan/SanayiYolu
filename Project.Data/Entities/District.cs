using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class District : EntityBase
    {
        public Guid CityId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }

        public City City { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
