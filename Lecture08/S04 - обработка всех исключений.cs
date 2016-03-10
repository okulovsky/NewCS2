using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {

        static void Method1()
        {
            Console.WriteLine("Метод 1");
            throw new Exception();
        }


        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += ProcessException;

            Method1();
        }

        static void ProcessException(object sender, UnhandledExceptionEventArgs args)
        {
            Console.WriteLine((args.ExceptionObject as Exception).StackTrace);
            Environment.Exit(1);
        }
    }
}
