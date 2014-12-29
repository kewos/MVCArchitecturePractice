using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Data.Contrast.Context;
using MVCArchitecturePractice.Core;
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
        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return Find(expression).FirstOrDefault();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return GetAll().AsQueryable().Where(expression);
        }

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
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteById(long id)
        {
            using (var context = new TContext())
            {
                var target = context.Set<TEntity>().Where(n => n.ID == id).FirstOrDefault();
                if (target != null as TEntity)
                {
                    context.Set<TEntity>().Remove(target);
                    context.SaveChanges();
                }
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
                return context.Set<TEntity>().ToList();
            }
        }
        #endregion
    }

    public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, MyDbContext>
        where TEntity : BaseEntity
    {

    }
}
