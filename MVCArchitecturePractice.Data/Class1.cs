using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Data.Repositories;
using MVCArchitecturePractice.Core.Entity;

namespace MVCArchitecturePractice.Data
{
    class Program
    {
        public static void Main()
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            //container
            //    .RegisterType<IUserRepository, UserRepository>()
            //    .Configure<Interception>()
            //    .SetInterceptorFor<IUserRepository>(new InterfaceInterceptor());

            //var userRepository = container.Resolve<IUserRepository>();
            //var user = new User { Email = "abc", Name = "abc", Password = "abc", Address = "abc" };
            //userRepository.Insert(user);

            container
                .RegisterType<IMessageRepository, MessageRepository>()
                .Configure<Interception>()
                .SetInterceptorFor<IMessageRepository>(new InterfaceInterceptor());

            var message = container.Resolve<IMessageRepository>();
            message.Insert(new Message { Comment = "asdfasdfasdf", UserId = 1 });
        }
    }
}
