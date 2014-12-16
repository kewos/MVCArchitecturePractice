using System;
using System.Data.Entity;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data.Contrast.Context
{
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// DBContext本身就有實作此方法
        /// </summary>
        int SaveChanges();
    }
}
