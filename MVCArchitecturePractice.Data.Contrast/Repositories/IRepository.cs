using System.Linq.Expressions;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using System.Collections.Generic;
using MVCArchitecturePractice.Common.Attribute;
using MVCArchitecturePractice.Core;

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
        [Logger]
        [CatchException]
        TEntity GetById(long id);

        /// <summary>
        /// Insert 實體
        /// </summary>
        [Logger]
        [CatchException]
        void Insert(TEntity entity);

        /// <summary>
        /// Update 實體
        /// </summary>
        [Logger]
        [CatchException]
        void Update(TEntity entity);

        /// <summary>
        /// Delete 實體
        /// </summary>
        [Logger]
        [CatchException]
        void Delete(TEntity entity);

        /// <summary>
        /// Delete 透過 Id
        /// </summary>
        [Logger]
        [CatchException]
        void DeleteById(long id);
    }
}
