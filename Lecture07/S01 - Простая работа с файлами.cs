using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide01
{
    class Program
    {
        static void MainX(string[] args)
        {
            File.WriteAllText("text", "Привет, мир!");
            
            var bytes = File.ReadAllBytes("text");

            int position = 0;
            foreach(var b in bytes)
            {
                Console.WriteLine("{0,2}: {1:X} {2}", position++, b, (char)b);
            }
        }
    }
}
