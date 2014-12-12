using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Data.Context;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyDbContext();
        }
    }
}
