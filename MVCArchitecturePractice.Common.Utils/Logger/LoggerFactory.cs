using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new Logger();
        }
    }
}
