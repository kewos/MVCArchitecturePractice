using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace MVCArchitecturePractice.Common.Utils.IocContainer
{
    public class IocContainer
    {
        private static readonly IUnityContainer container;

        static IocContainer()
        {
            container = new UnityContainer();
            container.AddNewExtension<Interception>();
        }

        public static void Register<TInterface, TImplement>() 
            where TImplement : class, TInterface
        {
            container.RegisterType<TInterface, TImplement>();
        }

        public static void SetInterfaceInterceptor<TInterface>()
        {
            container.Configure<Interception>().SetInterceptorFor<TInterface>(new InterfaceInterceptor());
        }

        public static TInterface GetInstance<TInterface>()
        {
            return container.Resolve<TInterface>();
        }
    }
}
