using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using System.Collections.Generic;
using MVCArchitecturePractice.Common.Attributes;

namespace MVCArchitecturePractice.Data.Contrast.Repositories
{
    public interface IRepository<TEntity> 
        where TEntity : BaseEntity
    {
        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        [Logger]
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// 取得實體透過ID
        /// </summary>
        /// <returns></returns>
        [CatchException]
        [Logger]
        TEntity GetById(long id);

        /// <summary>
        /// Insert 實體
        /// </summary>
        [CatchException]
        [Logger]
        void Insert(TEntity entity);

        /// <summary>
        /// Update 實體
        /// </summary>
        [CatchException]
        [Logger]
        void Update(TEntity entity);

        /// <summary>
        /// Delete 實體
        /// </summary>
        [CatchException]
        [Logger]
        void Delete(TEntity entity);
    }
}
