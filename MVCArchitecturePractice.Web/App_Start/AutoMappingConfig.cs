using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Web.Models;

namespace MVCArchitecturePractice.Web.App_Start
{
    public class AutoMappingConfig
    {
        public static void Initial()
        {
            Mapper.Initialize();
        }
    }

    public class MessageModelToMessageEntity : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "MessageModelToMessageEntity";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<mess
>
        }
    }
}