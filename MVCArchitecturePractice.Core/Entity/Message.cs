using System;

namespace MVCArchitecturePractice.Core.Entity
{
    public class Message : BaseEntity
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
    }
}
