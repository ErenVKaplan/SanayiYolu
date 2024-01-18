using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Abstract
{
    public interface IAddressService
    {
        Task<List<Country>> GetAllCountriesAsync();
        Task<List<City>> GetAllCitiesAsync();
        Task<List<District>> GetAllDistrictsAsync();
        Task<List<City>> GetAllCitiesByCountryIdAsync(Guid Id);
        Task<List<District>> GetAllDistrictsByCityIdAsync(Guid Id);
    }
}
