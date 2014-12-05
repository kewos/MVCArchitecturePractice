using System.Data.Entity;
using MVCArchitecturePractice.Core;

namespace MVCArchitecturePractice.Data
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
