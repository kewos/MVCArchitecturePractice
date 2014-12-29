using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVCArchitecturePractice.Core;
using MVCArchitecturePractice.Core.Contrast;

namespace MVCArchitecturePractice.Data.Contrast.Context
{
    public interface IDbContext : ISql
    {
        /// <summary>
        /// 取得Entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// 儲存修改
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <summary>
        /// 更新時使用
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;
    }
}
