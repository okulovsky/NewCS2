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
			PrivateMethod();
		}
		
		private void PrivateMethod() {}
		
		public static void PublicStaticMethod() 
		{
			//нельзя обращаться к нестатическому полю из статического метода
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
			//нельзя обращаться к приватным членам класса извне класса
			//obj.privateField = 1;
			//obj.PrivateMethod();

			MyClass.publicStaticField = 1;
			MyClass.PublicStaticMethod();

			//нельзя обращаться к нестатическим членам через имя класса
			//MyClass.publicField = 1;
			//MyClass.PublicMethod();

			//нельзя обращаться к статическим членам через имя объекта
			//obj.publicStaticField = 1;
			//obj.PublicStaticMethod();
		}
	}
}
