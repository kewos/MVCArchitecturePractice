using System;
using MVCArchitecturePractice.Data;
using MVCArchitecturePractice.Core.Data;
using MVCArchitecturePractice.Service;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace MVCArchitecturePractice.Web.App_Start
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = 
            new Lazy<IUnityContainer>(() => new UnityContainer());

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
    }
}
