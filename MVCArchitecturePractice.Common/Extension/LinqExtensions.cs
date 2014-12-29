using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
