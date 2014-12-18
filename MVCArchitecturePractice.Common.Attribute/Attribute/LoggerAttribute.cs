﻿using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Aop;

namespace MVCArchitecturePractice.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class LoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LoggerHandler();
        }
    }
}
