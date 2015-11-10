using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    public class MyClass
    {
		private int evenNumber;
		public int EvenNumber 
		{ 
			get
			{
				return evenNumber;
			}
			set
			{
				if (value % 2 != 0) throw new ArgumentException();
				evenNumber = value;
			}
		}

		private int someField;

		public int PropertyWithLogging
		{
			get
			{
				Console.WriteLine("Getter");
				return someField;
			}
			set
			{
				Console.WriteLine("Setter");
				someField = value;
			}
		}

		public void TestPropertyWithLogging()
		{
			PropertyWithLogging = 2;
			var temp = PropertyWithLogging;
			PropertyWithLogging += 1;
		}

		private int someNumber;
		public int SomeNumber 
		{ 
			get 
			{ 
				return someNumber; 
			} 
			set
			{
				someNumber = value;
			}
		}

		public int SomeOtherNumber { get; set; }
		
		public int ReadOnlyNumber { get; private set; }
		
		public int CalculatingProperty
		{
			get
			{
				return someNumber * 2;
			}
		}
        
		public static void Main()
		{
			new MyClass().TestPropertyWithLogging();
		}
    }
}
