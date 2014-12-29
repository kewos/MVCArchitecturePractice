using System;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Core.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
