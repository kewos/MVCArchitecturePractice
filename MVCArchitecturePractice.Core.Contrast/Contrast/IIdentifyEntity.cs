using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// 有AutoIncreaseID 的Entity都繼承這個Interface 
    /// </summary>
    public interface IIdentifyEntity
    {
        Int64 ID { get; set; }
    }
}
