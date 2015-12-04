using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide12
{
    public class BaseClass
    {
        public virtual void DoStuff() { Console.WriteLine("Base class"); }
    }

	public class DerivedClass : BaseClass
	{
		public new void DoStuff() { Console.WriteLine("Inherited class"); }
	}
	

    class Program
    {
        static void MainX(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.DoStuff();

            BaseClass baseClass = (BaseClass)derived;
            baseClass.DoStuff();
        }
    }
}
