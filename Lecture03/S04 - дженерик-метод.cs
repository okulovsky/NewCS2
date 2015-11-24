using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {
        static T FindMax<T>(T[] array)
			where T : IComparable
		{
			if (array.Length == 0) throw new ArgumentException();
			T max = array[0];
			for (int i=1;i<array.Length;i++)
				if (max.CompareTo(array[i])<
		}
    }
}
