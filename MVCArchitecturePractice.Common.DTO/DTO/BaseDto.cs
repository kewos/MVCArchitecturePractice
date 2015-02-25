using System;

namespace MVCArchitecturePractice.Common.DTO
{
    public abstract class BaseDTO
    {
        #region Properties
        public Int64 ID { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        #endregion
    }
}
