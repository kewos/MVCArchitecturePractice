﻿using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Aops;

namespace MVCArchitecturePractice.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CatchExceptionAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new CatchExceptionHandler();
        }
    }
}