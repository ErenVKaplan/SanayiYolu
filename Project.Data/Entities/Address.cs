using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Address : EntityBase
    {
        public Guid StoreId { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public Guid DistrictId { get; set; }

        public string AddressName { get; set; }
        public string AddressDescription { get; set; }

        public Store Store { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    }
}
