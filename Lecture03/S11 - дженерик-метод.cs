using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {
        static T FindMax<T>(IEnumerable<T> en)
			where T : IComparable
		{
            bool firstTime = true;
			T max = default(T);
            foreach(var e in en)
                if (firstTime || max.CompareTo(e) < 0)
                {
                    max = e;
                    firstTime = false;
                }
            return max;
		}

        static void MainX()
        {
			var a = FindMax(new[] { 3, 4, 1 });
			Console.WriteLine(a);
        }
    }
}
