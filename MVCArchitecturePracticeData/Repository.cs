using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core;
using System.Data.Entity;

namespace MVCArchitecturePractice.Data
{
    public class Repository<TEntity> where TEntity : BaseEntity
    {
        private readonly MyDbContext context;
        private IDbSet<TEntity> entities;

        public Repository(MyDbContext context)
        {
            this.context = context;
        }

        public IDbSet<TEntity> Entities
        {
            get
            {
                if (entities == null)
                { 
                    entities = context.Set<TEntity>();
                }
                return entities;
            }
        }

        public TEntity GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    return;
                }
                Entities.Add(entity);
                context.SaveChanges();
            }
            catch (Exception e)
            { 
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    return;
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    return;
                }
                Entities.Remove(entity);
                context.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public IQueryable<TEntity> Table
        {
            get
            {
                return this.Entities;
            }
        }
    }
}
