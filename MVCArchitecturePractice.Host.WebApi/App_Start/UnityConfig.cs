﻿using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Extension;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data;
using MVCArchitecturePractice.Data.Repository;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Business;
using MVCArchitecturePractice.Business.Contrast;

namespace MVCArchitecturePractice.Host.WebApi
{
    public static class UnityConfig
    {
        private static List<Action<IUnityContainer>> Config
        {
            get
            {
                return new List<Action<IUnityContainer>>
                {
                    RegisterRepositoryConfig,
                    RegisterBusinessConfig,
                };
            }
        }

        public static IUnityContainer Configure()
        {
            return BuildUnityContainer();
        }

        private static IUnityContainer BuildUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            RegisterConfig(container);
            return container;
        }

        /// <summary>
        /// 透過Unity 載入設定
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterConfig(IUnityContainer container)
        {
            container.AddNewExtension<Interception>();
            Config.ForEach(config => config(container));
        }

        #region private method
        /// <summary>
        /// 載入Repository 設定
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterRepositoryConfig(IUnityContainer container)
        {
            container.RegisterType<IRepositoryFactory, RepositoryFactory>(new InjectionConstructor(container));
            container.RegistTypeAndSetInteceptor<IUserRepository, UserRepository>();
            container.RegistTypeAndSetInteceptor<IMessageRepository, MessageRepository>();
        }

        /// <summary>
        /// 載入Business 設定
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterBusinessConfig(IUnityContainer container)
        {
            container.RegisterType<IBusinessFactory, BusinessFactory>(new InjectionConstructor(container));
            container.RegisterType<IMessageBoardBusiness, MessageBoardBusiness>();
        }
        #endregion
    }
}