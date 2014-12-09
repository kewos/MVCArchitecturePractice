using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MVCArchitecturePractice
{
    public static class AssemblyExtension
    {
        public static List<Type> GetInheritedTypes(this Assembly assembly, Type type)
        {
            return assembly.GetTypes()
                .Where(x =>
                    x.BaseType != null 
                    && x.BaseType.Namespace == type.BaseType.Namespace
                    && x.BaseType.Name == type.BaseType.Name)
                .ToList();
        }
    }
}
