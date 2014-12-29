using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVCArchitecturePractice.Core;
using MVCArchitecturePractice.Core.Contrast;

namespace MVCArchitecturePractice.Data.Contrast.Context
{
    public interface IDbContext : ISql
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
