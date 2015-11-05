using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
    class Point
    {
        public int X;
        public int Y;
    }



    class Program
    {
        static void Main(string[] args)
        {
            int N = 10000000;
            var timer = new Stopwatch();

            var before = GC.GetTotalMemory(false);
            timer.Start();
            var points = new Point[N];
            for (int i = 0; i < points.Length; i++)
                points[i] = new Point();
            var after = GC.GetTotalMemory(false);
            timer.Stop();

            Console.WriteLine((double)(after - before) / N);
            Console.WriteLine(timer.ElapsedMilliseconds);
       

        }
    }
}
