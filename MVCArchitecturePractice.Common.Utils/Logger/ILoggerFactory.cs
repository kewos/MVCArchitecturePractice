﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public interface ILoggerFactory
    {
        /// <summary>
        /// Create Logger
        /// </summary>
        /// <returns>ILogger</returns>
        ILogger Create();
    }
}