using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide01
{
	class BaseClass
	{
		public int PublicField;
		private int PrivateField;
		protected int ProtectedField;

		public void PublicMethod()
		{
			Console.WriteLine(PublicField);
			Console.WriteLine(PrivateField);
			Console.WriteLine(ProtectedField);
		}
	}

	class DerivedClass : BaseClass
	{
		public int AnotherPublicField;
		
		public void AnotherPublicMethod()
		{
			Console.WriteLine(PublicField);
			//Console.WriteLine(PrivateField);
			Console.WriteLine(ProtectedField);
			Console.WriteLine(AnotherPublicField);
		}
	}

    class Program
    {
        static void MainX(string[] args)
        {
			var obj = new DerivedClass();
			Console.WriteLine(obj.PublicField);
			//Console.WriteLine(PrivateField);
			//Console.WriteLine(obj.ProtectedField);
			Console.WriteLine(obj.AnotherPublicField);
        }
    }
}
