using System;

namespace MVCArchitecturePractice.Common.DTO
{
    public class MessageDTO : BaseDTO
    {
        public string Comment { get; set; }
        public Int64 UserId { get; set; }
    }
}
