using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lecture01.Lib;

namespace Slide12
{
    class Program
    {
        static void MainX(string[] args)
        {
            var obj = new PublicClass();
            Console.WriteLine(obj.PublicMethod());
            //Console.WriteLine(obj.PrivateMethod());
            //Console.WriteLine(obj.InternalMethod());

			//var obj1 = new InternalClass();
            
        }
    }
}
