using ApplicationCore.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, GetUserDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
        }

    }
}
