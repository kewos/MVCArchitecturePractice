using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    internal static class LoggerFactoryManager
    {
        private static ILoggerFactory factory = null;

        /// <summary>
        /// Set Factory Type with T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal static void SetFactory<T>()
            where T : ILoggerFactory
        {
            if (factory == (ILoggerFactory)null || factory.GetType() != typeof(T))
            {
                factory = (T)Activator.CreateInstance(typeof(T));
            }
        }

        /// <summary>
        /// Create Logger
        /// </summary>
        internal static ILogger Create
        {
            get
            {
                return (factory == (ILoggerFactory)null) ? null : factory.Create();
            }
        }
    }
}
