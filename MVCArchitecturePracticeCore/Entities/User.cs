using System;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
