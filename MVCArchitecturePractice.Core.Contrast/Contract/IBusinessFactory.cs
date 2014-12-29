using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// 商業邏輯工廠
    /// </summary>
    public interface IBusinessFactory
    {
        TBusiness GetBusiness<TBusiness>() 
            where TBusiness : IBusiness;
    }
}
