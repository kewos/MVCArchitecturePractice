using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    internal class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine("msg:{0}", msg);
        }

        public void Log(string msg, Exception exception)
        {
            Console.WriteLine("msg:{0}", msg);
        }
    }
}
