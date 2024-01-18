using Project.Data.Entities;
using Project.Data.ViewModels.StoreComments;
using Project.Data.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Abstract
{
    public interface IUserService
    {
        Task<UserProfileViewModel> GetUserDetailsAsync();
        Task<ServiceResponse<object>> CreateUserAsync(UserRegisterViewModel model);
        Task<ServiceResponse<object>> LoginUserAsync(UserLoginViewModel model);
        Task<ServiceResponse<object>> UpdateProfileDetailsAsync(UserProfileViewModel model);
        Task<ServiceResponse<object>> UpdatePasswordAsync(ResetPasswordViewModel model);


        Task<List<FavouriteStore>> GetAllFavouriteStoresAsync();
        Task<ServiceResponse<object>> ToggleLikeStoreAsync(Guid StoreId);


        Task<ServiceResponse<object>> CreateComment(StoreCommentCreateViewModel model);
        Task<List<StoreComment>> GetAllUserComments();
    }
}
