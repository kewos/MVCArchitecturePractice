using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    public interface IIdentifyEntity
    {
        /// <summary>
        /// 流水號ID
        /// </summary>
        Int64 ID { get; set; }
    }
}
