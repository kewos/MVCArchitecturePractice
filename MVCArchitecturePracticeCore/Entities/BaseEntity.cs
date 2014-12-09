using System;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Core.Entities
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public BaseEntity()
        {
            AddedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}
