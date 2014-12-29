using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// 服務工廠使用的Interface
    /// </summary>
    public interface IServiceFactory
    {
        /// <summary>
        /// 取得服務
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        TService GetService<TService>() where TService : IService;
    }
}
