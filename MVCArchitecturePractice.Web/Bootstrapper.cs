using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Service;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Data.Contrast.Context;
using MVCArchitecturePractice.Data.Repositories;
using MVCArchitecturePractice.Data.Context;

namespace MVCArchitecturePractice.Web
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initial()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

            container.RegisterType<IDbContext, MyDbContext>();

            //Repository
            container.RegisterType<IUserRepository, UserRepository>()
                .Configure<Interception>()
                .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

            container.RegisterType<IMessageRepository, MessageRepository>()
                .Configure<Interception>()
                .SetInterceptorFor<IMessageRepository>(new InterfaceInterceptor());

            //Service
            container.RegisterType<IMessageBoardService, MessageBoardService>();
        }
    }
}