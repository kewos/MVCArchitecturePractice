using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Common.Attributes;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Data.Repositories;
using MVCArchitecturePractice.Data.Context;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data
{
    class Program
    {
        public static void Main()
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container
                .RegisterType<IUserRepository, UserRepository>()
                .Configure<Interception>()
                .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

            var user = container.Resolve<IUserRepository>();
            user.GetById(1);
        }
    }
}
