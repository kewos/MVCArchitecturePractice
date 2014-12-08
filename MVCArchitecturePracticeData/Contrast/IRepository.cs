using System.Linq;

namespace MVCArchitecturePractice.Data
{
    public interface IRepository<TEntity> where TEntity : MVCArchitecturePractice.Core.BaseEntity
    {
        System.Data.Entity.IDbSet<TEntity> Entities { get; }
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> Table { get; }
    }
}
