using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Host.WebApi.Models;

namespace MVCArchitecturePractice.Host.WebApi.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(m =>
                {
                    m.AddProfile<MessageEntityToMessageModel>();
                    m.AddProfile<UserEntityToUserModel>();
                });
        }
    }

    /// <summary>
    /// UserEntity 轉成 UserModel
    /// </summary>
    public class UserEntityToUserModel : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserModel>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.Password, y => y.MapFrom(s => s.Password))
                .ForMember(x => x.Address, y => y.MapFrom(s => s.Address))
                .ForMember(x => x.Email, y => y.MapFrom(s => s.Email))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));
        }
    }

    /// <summary>
    /// MessageEntity 轉成 MessageModel
    /// </summary>
    public class MessageEntityToMessageModel : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Message, MessageModel>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.UserId, y => y.MapFrom(s => s.UserId))
                .ForMember(x => x.Comment, y => y.MapFrom(s => s.Comment))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));

            Mapper.CreateMap<MessageModel, Message>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.UserId, y => y.MapFrom(s => s.UserId))
                .ForMember(x => x.Comment, y => y.MapFrom(s => s.Comment))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));
        }
    }
}