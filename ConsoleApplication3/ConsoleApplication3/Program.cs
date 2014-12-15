using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;
using System.Diagnostics;
using Microsoft.Practices.Unity;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container
              .RegisterType<ICalculator, Calculator>()
              .Configure<Interception>()
              .SetInterceptorFor<ICalculator>(new InterfaceInterceptor());

            // Resolve
            ICalculator calc = container.Resolve<ICalculator>();

            // Call method
            calc.Add(1, 2);
            calc.Multiply(1, 2);
            //var container = new UnityContainer();
            //container.AddNewExtension<Interception>();
            //container.RegisterType<ILog, ConsoleLog>(
            //    new Interceptor<InterfaceInterceptor>(),
            //    new InterceptionBehavior<LoggingInterceptionBehavior>(),
            //    new InterceptionBehavior<PerformanceInterceptionBehavior>());

            //var logger = container.Resolve<ILog>();
            //logger.Log("Hello, Unity Framework!");
            //Console.ReadKey();
        }
    }
#region
    public interface ILog
    {
        void Log(string message);
    }

    class ConsoleLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class LoggingInterceptionBehavior : IInterceptionBehavior
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            // Before invoking the method on the original target.
            WriteLog(String.Format("Invoking method {0} at {1}",
                input.MethodBase,
                DateTime.Now.ToLongTimeString()));

            // Invoke the next behavior in the chain.
            var result = getNext()(input, getNext);

            // After invoking the method on the original target.
            if (result.Exception != null)
            {
                WriteLog(String.Format("Method {0} threw exception {1} at {2}",
                    input.MethodBase,
                    result.Exception.Message,
                    DateTime.Now.ToLongTimeString()));
            }
            else
            {
                WriteLog(String.Format("Method {0} returned {1} at {2}",
                    input.MethodBase,
                    result.ReturnValue,
                    DateTime.Now.ToLongTimeString()));
            }

            return result;
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute
        {
            get { return true; }
        }

        private void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }

    class PerformanceInterceptionBehavior : IInterceptionBehavior
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();

            // Invoke the next behavior in the chain.
            var result = getNext()(input, getNext);

            // After invoking the method on the original target.
            if (result.Exception != null)
            {
                WriteLog(String.Format("Method {0} threw exception {1} at {2}",
                    input.MethodBase,
                    result.Exception.Message,
                    DateTime.Now.ToLongTimeString()));
            }
            else
            {
                stopwatch.Stop();
                WriteLog(String.Format("Method {0} executed {1}", input.MethodBase, stopwatch.Elapsed));
            }

            return result;
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute
        {
            get { return true; }
        }

        private void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
#endregion


    internal class ExceptionLoggerCallHandler : ICallHandler
    {
        public IMethodReturn Invoke(
          IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn result = getNext()(input, getNext);
            if (result.Exception != null)
            {
                Console.WriteLine("ExceptionLoggerCallHandler:");
                Console.WriteLine("\tParameters:");
                for (int i = 0; i < input.Arguments.Count; i++)
                {
                    var parameter = input.Arguments[i];
                    Console.WriteLine(
                      string.Format("\t\tParam{0} -> {1}", i, parameter.ToString()));
                }
                Console.WriteLine();
                Console.WriteLine("Exception occured: ");
                Console.WriteLine(
                  string.Format("\tException -> {0}", result.Exception.Message));

                Console.WriteLine();
                Console.WriteLine("StackTrace:");
                Console.WriteLine(Environment.StackTrace);
            }

            return result;
        }


        public int Order { get; set; }
    }


    internal class LoggerHandler : ICallHandler
    {
        public IMethodReturn Invoke(
          IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn result = getNext()(input, getNext);
            Console.WriteLine("test");
            return result;
        }


        public int Order { get; set; }
    }

    internal class ExceptionLoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new ExceptionLoggerCallHandler();
        }
    }

    internal class LoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LoggerHandler();
        }
    }

    public interface ICalculator
    {
        [Logger]
        int Add(int first, int second);

        [ExceptionLogger]
        int Multiply(int first, int second);
    }

    class Calculator : ICalculator
    {

        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }
    }
}
