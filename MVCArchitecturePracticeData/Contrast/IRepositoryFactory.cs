using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data.Contrast
{
    public interface IRepositoryFactory
    {
        IRepository<TEntity> GetRepository<TEntity>() 
            where TEntity : BaseEntity, new();
    }
}
