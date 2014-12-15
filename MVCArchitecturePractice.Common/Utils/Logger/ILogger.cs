using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public interface ILogger
    {
        void Log(string msg);

        void Log(string msg, Exception exception);
    }
}
