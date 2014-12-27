﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Service.Dto;
using MVCArchitecturePractice.Core.Entities;
using AutoMapper;

namespace MVCArchitecturePractice.Service.AutoMap
{
    /// <summary>
    /// UserEntity 轉成 UserModel
    /// </summary>
    public class UserEntityToUserModel : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserDto>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.Password, y => y.MapFrom(s => s.Password))
                .ForMember(x => x.Address, y => y.MapFrom(s => s.Address))
                .ForMember(x => x.Email, y => y.MapFrom(s => s.Email))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));
        }
    }
}