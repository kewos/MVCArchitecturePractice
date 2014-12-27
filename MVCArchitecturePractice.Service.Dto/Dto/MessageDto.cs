using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Service.Dto
{
    public class MessageDto : BaseDto
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
    }
}
