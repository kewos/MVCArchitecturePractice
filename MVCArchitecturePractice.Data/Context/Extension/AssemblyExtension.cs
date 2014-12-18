using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MVCArchitecturePractice
{
    public static class AssemblyExtension
    {
        public static List<Type> GetInheritedTypes(this Assembly assembly, Type inheritedTypes)
        {
            return assembly.GetTypes()
              .Where(type => !String.IsNullOrEmpty(type.Namespace))
              .Where(type =>
                  type.BaseType != null 
                  && type.BaseType.IsGenericType
                  && type.BaseType.GetGenericTypeDefinition() == inheritedTypes)
                  .ToList();
                   
        }
    }
}
