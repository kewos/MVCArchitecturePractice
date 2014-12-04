using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using MVCArchitecturePractice.Data;
using MVCArchitecturePractice.Core.Data;

namespace MVCArchitecturePractice.Web.App_Start
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            var context = new MyDbContext();
            container.RegisterType<IRepository<Message>, Repository<Message>>(new InjectionConstructor(context));
        }
    }
}