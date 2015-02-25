using MVCArchitecturePractice.Core.Contrast;
using Microsoft.Practices.Unity;

namespace MVCArchitecturePractice.Data
{
    public class RepositoryFactory : IRepositoryFactory
    {
        IUnityContainer container;

        public RepositoryFactory(IUnityContainer container)
        {
            this.container = container;
        }

        public TRepository GetRepository<TRepository>() where TRepository : IRepository
        {
            return container.Resolve<TRepository>();
        }
    }
}
