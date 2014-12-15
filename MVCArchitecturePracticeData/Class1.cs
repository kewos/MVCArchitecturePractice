using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Common.Attributes;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Data.Contrast;
using MVCArchitecturePractice.Data.Context;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data
{
    class Program
    {
        public static void Main()
        {
            var context = new MyDbContext();
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container
                .RegisterType<IRepository<User>, Repository<User>>(new InjectionConstructor(context))
                .Configure<Interception>()
                .SetInterceptorFor<IRepository<User>>(new InterfaceInterceptor());

            var user = container.Resolve<IRepository<User>>();
            user.GetById(1);
        }
    }
}
