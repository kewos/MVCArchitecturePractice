using System;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public static class LoggerFactoryManager
    {
        private static ILoggerFactory factory;

        /// <summary>
        /// Set Factory Type with T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void SetFactory<T>()
            where T : ILoggerFactory
        {
            if (factory == null || factory.GetType() != typeof(T))
            {
                factory = (T)Activator.CreateInstance(typeof(T));
            }
        }

        /// <summary>
        /// Create Logger
        /// </summary>
        public static ILogger Create
        {
            get
            {
                return (factory == (ILoggerFactory)null) ? null : factory.Create();
            }
        }
    }
}
