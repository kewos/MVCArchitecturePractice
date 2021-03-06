﻿using System;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public interface ILogger
    {
        /// <summary>
        /// Log
        /// </summary>
        /// <param name="msg">訊息</param>
        void Log(string msg);

        /// <summary>
        /// Log
        /// </summary>
        /// <param name="msg">訊息</param>
        /// <param name="exception">例外</param>
        void Log(string msg, Exception exception);
    }
}
