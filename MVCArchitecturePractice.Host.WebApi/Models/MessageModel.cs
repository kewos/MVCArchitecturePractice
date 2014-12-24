using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Host.WebApi.Models
{
    public class MessageModel : BaseModel
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
    }
}
