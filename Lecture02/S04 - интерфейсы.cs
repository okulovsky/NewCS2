using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    interface IMyInterface1
    {
        void Method1();
    }

    interface IMyInterface2
    {
        void Method2();
    }

    class ClassImplementingFirstInterface : IMyInterface1
    {
        public void Method()
        {
            throw new NotImplementedException();
        }
    }

    class ClassImplementingBothInterfaces : ClassImplementingFirstInterface, IMyInterface2
    {
        public void Method2()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        public static void Main()
        {
            ClassImplementingFirstInterface implement1 = new ClassImplementingFirstInterface();
            ClassImplementingBothInterfaces implement1and2 = new ClassImplementingBothInterfaces();

            Console.WriteLine(implement1 is IMyInterface1);
            Console.WriteLine(implement1 is IMyInterface2);
            Console.WriteLine(implement1and2 is IMyInterface1);
            Console.WriteLine(implement1and2 is IMyInterface2);

            var correctCase1 = implement1and2 as IMyInterface1;
            var correctCase2 = (IMyInterface1)implement1and2;
            var correctCase3 = implement1 as IMyInterface1;

            var testCase = (IMyInterface1)implement1; // в отличие от ситуации с интерфейсами, это будет компилироваться

            implement1 = implement1and2;
            testCase = (IMyInterface1)implement1; // потому что после такого присвоения это было бы осмысленно


        }
    }


}
