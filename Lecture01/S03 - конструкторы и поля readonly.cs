using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
	public class MyClass
	{
		private int field;
		public readonly int ReadonlyField;
		public MyClass(int field, int readonlyField)
		{
			this.field=field;
			ReadonlyField=readonlyField;
		}
		public void Method()
		{
			field = 2;
			//ReadonlyField = 2;
		}
	}

	public class Program
	{
		public static void MainX()
		{
			//var obj = new MyClass();
			var obj = new MyClass(10, 10);
		}
	}
}
