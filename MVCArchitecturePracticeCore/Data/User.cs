using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Data
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
