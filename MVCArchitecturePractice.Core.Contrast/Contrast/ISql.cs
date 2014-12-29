using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// 資料庫都繼承這個interface
    /// </summary>
    public interface ISql : IDisposable
    {
    }
}
