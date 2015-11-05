using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    public class BaseClass
    {
        public virtual void DoStuff() { Console.WriteLine("Base class"); }
    }

    public class DerivedClass : BaseClass
    {
        public override /*new*/ void DoStuff() { Console.WriteLine("Inherited class"); }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.DoStuff();

            BaseClass baseClass = (BaseClass)derived;
            baseClass.DoStuff();
        }
    }
}
