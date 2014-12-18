using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace MVCArchitecturePractice.Common.Aops
{
    public class CatchExceptionHandler : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {

            try
            {
                IMethodReturn result = getNext()(input, getNext);
            }
            catch(Exception e)
            { 
            }


            return null;
        }
    }
}
