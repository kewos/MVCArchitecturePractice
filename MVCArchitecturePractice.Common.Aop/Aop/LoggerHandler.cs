using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;
using MVCArchitecturePractice.Common.Utils.Logger;

namespace MVCArchitecturePractice.Common.Aop
{
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
