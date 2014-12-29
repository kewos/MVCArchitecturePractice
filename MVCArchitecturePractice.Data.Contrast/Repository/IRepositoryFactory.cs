using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Contrast;

namespace MVCArchitecturePractice.Data.Contrast.Repository
{
    public interface IRepositoryFactory
    {
        /// <summary>
        /// 取得 Repository
        /// </summary>
        /// <typeparam name="TRepository"></typeparam>
        /// <returns></returns>
        TRepository GetRepository<TRepository>() where TRepository : IRepository;
    }
}
