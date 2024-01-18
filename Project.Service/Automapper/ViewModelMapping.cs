﻿using AutoMapper;
using Project.Data.Entities;
using Project.Data.ViewModels.Stores;
using Project.Data.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Automapper
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<AppUser, UserRegisterViewModel>().ReverseMap();
            CreateMap<AppUser, UserProfileViewModel>().ReverseMap();
            CreateMap<Store, StoreDetailsViewModel>().ReverseMap();
        }
      
    }
}
