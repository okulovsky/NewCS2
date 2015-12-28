using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
	public class SortedList<T>
		where T : IComparable
	{
		List<T> list;

		public SortedList()
		{
			list = new List<T>();
		}

		public T this[int index]
		{
			get { return list[index]; }
			set { list[index] = value; }
		}

		public void Add(T value)
		{
			for (int i = 0; i < list.Count;i++)
				if (list[i].CompareTo(value) < 0)
				{
					list.Insert(i, value);
					return;
				}
		}
	}

	class Program
	{
		public static void MainX()
		{
			var list = new SortedList<int>();
			var list2 = new SortedList<string>();

		}
	}
}
