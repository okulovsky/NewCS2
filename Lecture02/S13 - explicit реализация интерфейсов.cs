using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideXX
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

		public void Method()
		{
			//Do something
		}

		void IInterface2.Method()
		{
			//Do something else
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
