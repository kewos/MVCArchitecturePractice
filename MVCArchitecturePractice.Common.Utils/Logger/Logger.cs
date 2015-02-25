using System;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public class Logger : ILogger
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
