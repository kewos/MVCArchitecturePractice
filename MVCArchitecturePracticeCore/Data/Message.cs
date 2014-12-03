using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Core.Data
{
    public class Message : BaseEntity
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
    }
}
