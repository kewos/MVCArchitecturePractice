using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Data.Contrast
{
    public interface IRepository<TEntity> 
        where TEntity : BaseEntity
    {
        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// 取得實體透過ID
        /// </summary>
        /// <returns></returns>
        TEntity GetById(object id);

        /// <summary>
        /// Insert
        /// </summary>
        void Insert(TEntity entity);

        /// <summary>
        /// Update
        /// </summary>
        void Update(TEntity entity);

        /// <summary>
        /// Delete
        /// </summary>
        void Delete(TEntity entity);
    }
}
