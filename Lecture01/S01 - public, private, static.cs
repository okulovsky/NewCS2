using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide01
{
	public class MyClass
	{
		public int publicField;
		private int privateField;
		public static int publicStaticField;

		public void PublicMethod() 
		{
			Console.WriteLine(publicField);
			Console.WriteLine(privateField);
			Console.WriteLine(publicStaticField);
		}
		
		private void PrivateMethod() {}
		
		public static void PublicStaticMethod() 
		{
			//Console.WriteLine(publicField);
			//Console.WriteLine(privateField);
			Console.WriteLine(publicStaticField);
		}
	}

	public class Program
	{
		public static void MainX()
		{
			var obj = new MyClass();
			obj.publicField = 1;
			obj.PublicMethod();

			MyClass.publicStaticField = 1;
			MyClass.PublicStaticMethod();

			//MyClass.publicField = 1;
			//MyClass.PublicMethod();

			//obj.publicStaticField = 1;
			//obj.PublicStaticMethod();

			//obj.privateField = 1;
			//obj.PrivateMethod();
		}
	}
}
