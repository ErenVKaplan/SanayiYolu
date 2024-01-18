using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.ViewModels.Stores
{
    public class StoreRegisterViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StoreName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public Guid DistrictId { get; set; }

        public List<Country>? Countries { get; set; }
        public List<City>? Cities { get; set; }
        public List<District>? Districts { get; set; }
    }
}
