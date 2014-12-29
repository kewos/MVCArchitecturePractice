using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data.Contrast.Repository;
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

        //private static Dictionary<Type, IRepository> Repositories = new Dictionary<Type, IRepository>();

        //public static TRepository GetRepository<TRepository>()
        //    where TRepository : class, IRepository
        //{
        //    var type = typeof(TRepository);
        //    if (!Repositories.ContainsKey(type))
        //    {
        //        dynamic instance = Activator.CreateInstance(type);
        //        Repositories.Add(type, instance);
        //    }
        //    return Repositories[type] as TRepository;
        //}
    }
}
