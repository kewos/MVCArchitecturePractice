using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Common.Attributes;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace MVCArchitecturePractice.Common
{
    class Program
    {
        public static void Main()
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container
              .RegisterType<ICalculator, Calculator>()
              .Configure<Interception>()
              .SetInterceptorFor<ICalculator>(new InterfaceInterceptor());
            var calculator = container.Resolve<ICalculator>();
            calculator.Add(1, 2);
        }
    }

    public interface ICalculator
    {
        [Logger]
        void Add(int j, int k);
    }

    public class Calculator : ICalculator
    {
        public void Add(int j, int k)
        {
            Console.WriteLine("{0} + {1} = {2}", j, k, j + k);
        }
    }
}
