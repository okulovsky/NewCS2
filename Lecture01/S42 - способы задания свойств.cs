using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    class MyClass
	{
		//Следует использовать свойства, даже если нет проверки целостности
		int number;
		public int Number
		{
			get { return number; }
			set { number = value; }
		}

		public int AnotherNumber { get; set; }

		public int GetOnlyNumber { get; private set; }
		public readonly int ReadOnlyNumber;

		void Method()
		{
			GetOnlyNumber = 1;
			//нельзя изменять значения readonly полей
			//ReadOnlyNumber = 1;
		}

		public int Product
		{
			get { return Number * AnotherNumber; }
		}
	}
}
