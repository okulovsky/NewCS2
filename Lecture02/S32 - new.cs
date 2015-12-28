using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide32
{
    public class BaseClass
    {
        public virtual void Method() { Console.WriteLine("Base class"); }
    }

	public class DerivedClass : BaseClass
	{
		public new void Method() { Console.WriteLine("Inherited class"); }
	}
	

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
			derived.Method();

            BaseClass baseClass = (BaseClass)derived;
			baseClass.Method();
        }
    }
}
