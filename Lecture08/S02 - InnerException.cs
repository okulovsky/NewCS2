using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    class MyClass
    {
        static MyClass()
        {
            var n = int.Parse("abc");
        }
    }

    class Program
    {
        static void MainX()
        {
            Console.WriteLine("Начало Main");
            var e = new MyClass();
        }
    }
}
