using System;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Core.Entities
{
    public class Message : BaseEntity
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
    }
}
