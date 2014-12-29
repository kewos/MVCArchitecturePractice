using System;
using System.Data.Entity;
using MVCArchitecturePractice.Core;
using System.Data.Entity.Infrastructure;

namespace MVCArchitecturePractice.Data.Contrast.Context
{
    public interface IDbContext : IDisposable
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
