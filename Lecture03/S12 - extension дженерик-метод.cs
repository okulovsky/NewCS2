using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    static class EnumerableExtensions
    {
        public static T FindMax<T>(this IEnumerable<T> en)
           where T : IComparable
        {
            bool firstTime = true;
            T max = default(T);
            foreach (var e in en)
                if (firstTime || max.CompareTo(e) < 0)
                {
                    max = e;
                    firstTime = false;
                }
            return max;
        }

    }

    class Program
    {
       

        static void MainX()
        {
            var a= new [] { 1, 2, 4}.FindMax();
			Console.WriteLine(a);
        }
    }
}
