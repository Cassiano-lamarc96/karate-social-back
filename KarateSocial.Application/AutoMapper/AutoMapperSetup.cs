using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using KarateSocial.Application.ViewModels;
using KarateSocial.Domain.Entities;
using Profile = AutoMapper.Profile;

namespace KarateSocial.Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<UserViewModel, User>().ReverseMap();            
        }
    }
}
