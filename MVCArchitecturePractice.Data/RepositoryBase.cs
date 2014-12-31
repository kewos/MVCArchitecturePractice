using MVCArchitecturePractice.Core;
using MVCArchitecturePractice.Data.Context;
using MVCArchitecturePractice.Data.Repository;

namespace MVCArchitecturePractice.Data
{
    public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, MyDbContext>
            where TEntity : BaseEntity
    {
    }
}