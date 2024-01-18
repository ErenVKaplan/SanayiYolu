using Microsoft.AspNetCore.Http;
using Project.Data.Enums;
using Project.Data.ViewModels.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadViewModel> Upload(string name, IFormFile imageFile, ImageType imageType);
        void Delete(string imageName);
    }
}
