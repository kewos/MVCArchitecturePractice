using System;
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
    /// MessageEntity 轉成 MessageModel
    /// </summary>
    public class MessageEntityToMessageModel : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Message, MessageDto>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.UserId, y => y.MapFrom(s => s.UserId))
                .ForMember(x => x.Comment, y => y.MapFrom(s => s.Comment))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));

            Mapper.CreateMap<MessageDto, Message>()
                .ForMember(x => x.ID, y => y.MapFrom(s => s.ID))
                .ForMember(x => x.UserId, y => y.MapFrom(s => s.UserId))
                .ForMember(x => x.Comment, y => y.MapFrom(s => s.Comment))
                .ForMember(x => x.AddDate, y => y.MapFrom(s => s.AddDate))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(s => s.ModifyDate));
        }
    }
}
