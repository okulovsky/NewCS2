using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideXX
{
    class Program
    {

        static void UpdateInt(int n)
        {
            n++;
        }

        static void UpdateArray(int[] array)
        {
            array[0]++;
        }


        static void MainX(string[] args)
        {
            var n = 0;
            UpdateInt(n);
            Console.WriteLine(n);

            var array = new int[] { 0 };
            UpdateArray(array);
            Console.WriteLine(array[0]);
        }


        static void UpdateString(string s)
        {
            //s[0] = 'a';
        }
    }
}
