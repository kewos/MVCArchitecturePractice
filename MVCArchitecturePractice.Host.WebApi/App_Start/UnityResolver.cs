using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Http.Dependencies;

namespace MVCArchitecturePractice.Host.WebApi
{
    public class UnityResolver : IDependencyResolver
    {
        protected IUnityContainer container;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            container.Dispose();
        }
    }
}

//namespace MVCArchitecturePractice.Host.WebApi.App_Start
//{
//    /// <summary>
//    /// Specifies the Unity configuration for the main container.
//    /// </summary>
//    public class UnityConfig
//    {
//        #region Unity Container
//        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
//        {
//            var container = new UnityContainer();
//            RegisterTypes(container);
//            return container;
//        });

//        /// <summary>
//        /// Gets the configured Unity container.
//        /// </summary>
//        public static IUnityContainer GetConfiguredContainer()
//        {
//            return container.Value;
//        }
//        #endregion

//        /// <summary>Registers the type mappings with the Unity container.</summary>
//        /// <param name="container">The unity container to configure.</param>
//        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
//        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
//        public static void RegisterTypes(IUnityContainer container)
//        {
//            container.RegisterType<IDbContext, MyDbContext>();
//        }

//        private void RegisterDBContextConfig(IUnityContainer container)
//        {
//            container.RegisterType<IDbContext, MyDbContext>();
//            container.RegisterType<IUserRepository, UserRepository>()
//               .Configure<Interception>()
//               .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

//            container.RegisterType<IMessageRepository, MessageRepository>()
//                .Configure<Interception>()
//                .SetInterceptorFor<IMessageRepository>(new InterfaceInterceptor());
//            container.RegisterType<IMessageBoardService, MessageBoardService>();
//        }

//        /// <summary>
//        /// 載入Repository 設定
//        /// </summary>
//        /// <param name="container"></param>
//        private void RegisterRepositoryConfig(IUnityContainer container)
//        {
//            container.RegisterType<IUserRepository, UserRepository>()
//               .Configure<Interception>()
//               .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

//            container.RegisterType<IMessageRepository, MessageRepository>()
//                .Configure<Interception>()
//                .SetInterceptorFor<IMessageRepository>(new InterfaceInterceptor());
//        }

//        /// <summary>
//        /// 載入Service 設定
//        /// </summary>
//        /// <param name="container"></param>
//        private void RegisterServiceConfig(IUnityContainer container)
//        {
//            container.RegisterType<IMessageBoardService, MessageBoardService>();
//        }
//    }
//}
