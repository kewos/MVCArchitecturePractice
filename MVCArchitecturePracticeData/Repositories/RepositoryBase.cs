using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Data.Contrast.Context;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Context;

namespace MVCArchitecturePractice.Data.Repositories
{
    /// <summary>
    /// 透過Repository操作TContext
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public abstract class RepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : IDbContext, new()
    {
        #region IRepository<TEntity> Member
 
        public TEntity GetById(long id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(e => e.ID == id);
            }
        }

        public void Insert(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>();
            }
        }
        #endregion
    }

    public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, MyDbContext>
        where TEntity : BaseEntity
    {

    }
}
