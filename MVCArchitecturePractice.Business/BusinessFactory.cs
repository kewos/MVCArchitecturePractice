using MVCArchitecturePractice.Core.Contrast;
using Microsoft.Practices.Unity;

namespace MVCArchitecturePractice.Business
{
    public class BusinessFactory : IBusinessFactory
    {
        private IUnityContainer container;

        public BusinessFactory(IUnityContainer container)
        {
            this.container = container;
        }

        public TBusiness GetBusiness<TBusiness>() 
            where TBusiness : IBusiness
        {
            return container.Resolve<TBusiness>();
        }
    }
}
