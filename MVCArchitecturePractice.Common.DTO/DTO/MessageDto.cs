using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.DTO
{
    public class MessageDTO : BaseDTO
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
    }
}
