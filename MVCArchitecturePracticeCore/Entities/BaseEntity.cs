using System;
using System.Collections.Generic;
using System.ComponentModel;
using MVCArchitecturePractice.Core.Contracts;

namespace MVCArchitecturePractice.Core.Entities
{
    public abstract class BaseEntity : NotificationObject, IIdentifyEntity, IWithDayEntity
    {
        #region Properties
        public Int64 ID { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        #endregion

        public BaseEntity()
        {
            this.AddDate = DateTime.Now;
        }
    }
}
