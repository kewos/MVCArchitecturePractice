using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace MVCArchitecturePractice.Business.AutoMap
{
    public static class AutoMapperConfig
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
}