using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Data.Contrast;

namespace MVCArchitecturePractice.Data
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Core.Entities.BaseEntity, new()
        {
            throw new NotImplementedException();
        }
    }
}
