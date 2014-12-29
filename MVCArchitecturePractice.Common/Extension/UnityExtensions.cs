﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace MVCArchitecturePractice.Common.Extension
{
    public static class UnityExtensions
    {
        public static void RegistTypeAndSetInteceptor<TInterface, TClass>(this IUnityContainer container)
            where TClass : class, TInterface
        {
            container.RegisterType<TInterface, TClass>()
            .Configure<Interception>()
            .SetInterceptorFor<TInterface>(new InterfaceInterceptor());
        }
    }
}
