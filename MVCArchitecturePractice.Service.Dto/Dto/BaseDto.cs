using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Service.Dto
{
    public abstract class BaseDto
    {
        #region Properties
        public Int64 ID { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        #endregion
    }
}
