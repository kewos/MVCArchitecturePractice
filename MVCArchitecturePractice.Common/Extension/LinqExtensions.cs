using System;
using System.Collections.Generic;

namespace MVCArchitecturePractice.Common.Extendsion
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> elements, Action<T> action)
        {
            foreach (T element in elements)
            {
                action(element);
            }
        }
    }
}
