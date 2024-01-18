using Project.Data.Entities;
using Project.Data.ViewModels.StoreComments;
using Project.Data.ViewModels.StoreImages;
using Project.Data.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Abstract
{
    public interface IStoreService
    {
        Task<ServiceResponse<object>> LoginStoreAsync(StoreLoginViewModel model);
        Task<ServiceResponse<object>> CreateStoreAsync(StoreRegisterViewModel model);

        Task<ServiceResponse<object>> ToggleOnAir();


        Task<List<Store>> GetAllStoresAsync();
        Task<Store> GetStoreDetailsByStoreIdAsync(Guid Id);
        Task<Store> GetStoreDetailsAsync();

        Task<List<StoreComment>> GetAllStoreCommentsAsync();
        Task<List<StoreImage>> GetAllStoreImagesAsync();
        

        Task<ServiceResponse<object>> UpdateStoreDetailsAsync(StoreDetailsViewModel model);
        Task<ServiceResponse<object>> CreateStoreImageAsync(StoreImageCreateViewModel model);
        Task<ServiceResponse<object>> DeleteStoreImageAsync(Guid Id);
    }
}
