using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;
using MVCArchitecturePractice.Service;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data;

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
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            //Repository
            container.RegisterType<IRepository<User>, Repository<User>>();
            container.RegisterType<IRepository<Message>, Repository<Message>>();

            //Service
            container.RegisterType<IMessageBoardService, MessageBoardService>();
        }
    }
}