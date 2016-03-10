using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide011
{
    class MyException : Exception
    { }

    class Program
    {
        static void Method0()
        {
            throw new MyException();
        }

        static void Method1()
        {
            Console.WriteLine("Зашли в Method1");
            Method0();
        }

        static void Method2()
        {
            try
            {
                Console.WriteLine("Зашли в try");
                Method1();
            }
            catch(Exception e)
            {
                Console.WriteLine("Зашли в catch");
                throw;
            }
            finally
            {
                Console.WriteLine("Зашли в finally");
            }
        }


        static void MainX(string[] args)
        {
            Method2();
        }
    }
}
