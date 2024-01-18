using Project.Data.Entities;
using Project.Data.UnitOfWorks;
using Project.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Concrete
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork unitOfWork;

        public AddressService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            return await unitOfWork.GetRepository<Country>().GetAllAsync();
        }
        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await unitOfWork.GetRepository<City>().GetAllAsync();
        }
        public async Task<List<District>> GetAllDistrictsAsync()
        {
            return await unitOfWork.GetRepository<District>().GetAllAsync();
        }


        public async Task<List<City>> GetAllCitiesByCountryIdAsync(Guid Id)
        {
            return await unitOfWork.GetRepository<City>().GetAllAsync(predicate: x => x.CountryId == Id);
        }
        public async Task<List<District>> GetAllDistrictsByCityIdAsync(Guid Id)
        {
            return await unitOfWork.GetRepository<District>().GetAllAsync(predicate: x => x.CityId == Id);
        }
    }
}
