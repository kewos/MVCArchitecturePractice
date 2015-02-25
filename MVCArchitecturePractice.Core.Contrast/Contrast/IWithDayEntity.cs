using System;

namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// 有新增日期修改日期的Entity都繼承這個Interface
    /// </summary>
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
