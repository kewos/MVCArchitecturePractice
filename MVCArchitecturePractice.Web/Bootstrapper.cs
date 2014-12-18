using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Service;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Data.Contrast.Context;
using MVCArchitecturePractice.Data.Repositories;
using MVCArchitecturePractice.Data.Context;

namespace MVCArchitecturePractice.Web
{
    public static class Bootstrapper
    {
        private static List<Action<IUnityContainer>> UnityConfig
        {
            get
            {
                return new List<Action<IUnityContainer>>
                {
                    RegisterDBContextConfig,
                    RegisterRepositoryConfig,
                    RegisterServiceConfig
                };
            }
        }

        public static IUnityContainer Initial()
        {
            IUnityContainer container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            RegisterConfig(container);
            return container;
        }

        /// <summary>
        /// 透過Unity 載入設定
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterConfig(IUnityContainer container)
        {
            UnityConfig.ForEach(config => config(container));
        }

        #region private method
        private static void RegisterDBContextConfig(IUnityContainer container)
        {
            container.RegisterType<IDbContext, MyDbContext>();
        }

        private static void RegisterRepositoryConfig(IUnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>()
               .Configure<Interception>()
               .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

            container.RegisterType<IMessageRepository, MessageRepository>()
                .Configure<Interception>()
                .SetInterceptorFor<IMessageRepository>(new InterfaceInterceptor());
        }

        private static void RegisterServiceConfig(IUnityContainer container)
        {
            container.RegisterType<IMessageBoardService, MessageBoardService>();
        }
        #endregion
    }
}