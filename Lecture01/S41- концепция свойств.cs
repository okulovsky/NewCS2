using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide024
{
	public class MyClass
	{
		private int oddNumber;
		public int GetOddNumber() { return oddNumber; }
		public void SetOddNumber(int value)
		{
			if (value % 2 == 0)
			{
				throw new ArgumentException();
			}
			oddNumber = value;
		}


		private int evenNumber;
		public int EvenNumber
		{
			get 
			{
				Console.WriteLine("Вызван геттер");
				return evenNumber; 
			}
			set
			{
				Console.WriteLine("Вызван сеттер");
				if (value % 2 != 0)
				{
					Console.WriteLine("Исключение выброшено");
					throw new ArgumentException();
				}
				evenNumber = value;
			}
		}

	}

	class Program
	{
		public static void MainX()
		{
			var obj = new MyClass();
			obj.SetOddNumber(1);
			obj.SetOddNumber(obj.GetOddNumber() + 2);
			
			
			Console.WriteLine("Присвоение свойству значения");
			obj.EvenNumber = 2;

			Console.WriteLine("\n\nПолучение значения свойства");
			var a = obj.EvenNumber;

			Console.WriteLine("\n\nУвеличение значения свойства");
			obj.EvenNumber += 2;

			Console.WriteLine("\n\nНекорректное присвоение значения");
			try
			{
				obj.EvenNumber = 3;
			}
			catch
			{
				Console.WriteLine("Исключение обработано");
			}
		}
	}
}