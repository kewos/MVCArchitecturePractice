using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Core.Contrast;
using Microsoft.Practices.Unity;

namespace MVCArchitecturePractice.Service
{
    public class ServiceFactory : IServiceFactory
    {
        private IUnityContainer container;

        public ServiceFactory(IUnityContainer container)
        {
            this.container = container;
        }

        public TService GetService<TService>() where TService : IService
        {
            return container.Resolve<TService>();
        }
    }
}
