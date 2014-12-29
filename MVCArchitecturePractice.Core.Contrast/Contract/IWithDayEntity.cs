using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Contrast
{
    public interface IWithDayEntity
    {
        /// <summary>
        /// 新增日期
        /// </summary>
        DateTime AddDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        DateTime? ModifyDate { get; set; }
    }
}
