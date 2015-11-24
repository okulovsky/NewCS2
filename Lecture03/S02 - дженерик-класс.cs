using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    public class MyList<T>
	{
		List<T> list;

		public MyList()
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
			list.Add(value);
		}
	}
}
