using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
    class AlgorithmException : Exception
    {
        public AlgorithmException(Exception innerException)
            : base("", innerException)
        { }

        public AlgorithmException()
            : this(null)
        { }
    }

    class Program
    {
        static string Method(string argument)
        {
            try
            {
                var n = int.Parse(argument);
                return (2 * n).ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine("Делаем что-то полезное...");

                return null;
                throw;
                throw e;
                throw new AlgorithmException();
                throw new AlgorithmException(e);
            }
        }

        static void PrintException(Exception e)
        {
            Console.WriteLine(e.GetType() + "\n");
            Console.WriteLine(e.Message + "\n");
            Console.WriteLine(e.StackTrace + "\n");

            if (e.InnerException != null)
                PrintException(e.InnerException);
        }

        static void MainX(string[] args)
        {
            try
            {
                Method("abc");
            }
            catch(Exception e)
            {
                PrintException(e);
            }
        }
    }
}
