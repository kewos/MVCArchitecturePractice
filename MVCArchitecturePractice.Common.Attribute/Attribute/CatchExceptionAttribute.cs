using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Aop;

namespace MVCArchitecturePractice.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CatchExceptionAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new CatchExceptionHandler();
        }
    }

    public class CatchExceptionHandler : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn result = getNext()(input, getNext);
            return result;
        }
    }
}
