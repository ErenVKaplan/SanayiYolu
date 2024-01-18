using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.ViewModels.StoreImages
{
    public class StoreImageCreateViewModel
    {
        public List<IFormFile> Images { get; set; }
    }
}
