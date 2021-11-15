using System;
using AutoMapper;
using Notifiable.Application.ViewModels;
using Notifiable.Domain.Entities;

namespace Notifiable.Application.AutoMapperConfig
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
