using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide13
{
    interface IInterface1
	{
		void Method();
	}

	interface IInterface2
	{
		void Method();
	}

	public class Class : IInterface1, IInterface2
	{

		void IInterface1.Method()
		{
			Console.WriteLine("Interface 1");
		}

		void IInterface2.Method()
		{
			Console.WriteLine("Interface 2");
		}
	}


	class Program
	{
		public static void Main()
		{
			var obj = new Class();
			(obj as IInterface1).Method();
			(obj as IInterface2).Method();
			
			
		}
	}




	public class MyEnumerator : IEnumerator<int>
	{

		object System.Collections.IEnumerator.Current
		{
			get { throw new NotImplementedException(); }
		}

		public int Current
		{
			get { throw new NotImplementedException(); }
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}



		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}
	}
}
