using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
	public class MyClass
	{
		public int fieldWithDeafultValue = 5;
		public int publicField;
		public int publicReadonlyField;
		static public int staticPublicField;
		static public readonly int staticPublicReadonlyField;

		public MyClass(int c)
		{
			publicField = c;
			publicReadonlyField = c;
			staticPublicField = c;

			//статические readonly поля можно инициализировать только в статическом конструкторе
			//staticPublicReadonlyField = c;
		}

		public MyClass()
			: this(2)
		{ }

		static MyClass()
		{
			staticPublicField = 1;
			staticPublicReadonlyField = 1;

			//нельзя обращаться к нестатическому полю из статического метода
			//publicField=1;
			//publicReadonlyField=1;
		}
	}
}