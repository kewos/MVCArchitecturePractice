using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core;

namespace MVCArchitecturePractice.Data
{
    public class UnitOfWorker : IDisposable
    {
        private bool disposed = false; 
        private readonly MyDbContext context;
        private Dictionary<string, object> repositories;

        public UnitOfWorker(MyDbContext context)
        {
            this.context = context;
        }

        public UnitOfWorker()
        {
            this.context = new MyDbContext();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public Repository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var entityTypeName = typeof(TEntity).Name;

            if (!repositories.ContainsKey(entityTypeName))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), context);
                repositories.Add(entityTypeName, repositoryInstance);
            }

            return repositories[entityTypeName] as Repository<TEntity>;
        }
    }
}
