using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Aop;
using MVCArchitecturePractice.Common.Utils.Logger;

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

    public class LoggerHandler : ICallHandler
    {
        #region ICallHandler 成員
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn result = getNext()(input, getNext);
            LoggerFactoryManager.SetFactory<LoggerFactory>();
            LoggerFactoryManager.Create.Log(input.MethodBase.Name);
            return result;
        }
        #endregion
    }
}
