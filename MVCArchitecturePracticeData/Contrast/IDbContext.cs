using System.Data.Entity;

namespace MVCArchitecturePractice.Data.Contrast
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() 
            where TEntity : MVCArchitecturePractice.Core.Entities.BaseEntity;
        int SaveChanges();
    }
}
