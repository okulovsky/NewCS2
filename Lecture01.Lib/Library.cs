using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01.Lib
{
    public class PublicClass
    {
        public int PublicMethod() { return 0; }
        private int PrivateMethod() { return 0; }
        internal int InternalMethod() { return 0; }

        internal InternalClass InternalMethodReturnsInternalClass() { return new InternalClass(); }
    }


    internal class InternalClass
    {
    }

    public class SomeOtherClass
    {
        public int SomeMethod()
        {
            return new PublicClass().InternalMethod();
        }
    }

}
