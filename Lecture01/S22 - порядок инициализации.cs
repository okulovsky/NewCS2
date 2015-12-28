using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slide03
{
    class Helper
	{
		public static int Report(string str)
		{
			Console.WriteLine(str);
			return 0;
		}
	}

	class MyClass
	{
		static int staticField = Helper.Report("Инициализация статических полей");
		static MyClass()
		{
			Helper.Report("Статический конструктор");
		}
		int field = Helper.Report("Инициализация нестатических полей");
		public MyClass(int c)
		{
			Helper.Report("Конструктор, вызванный другим конструктором");
		}
		public MyClass() : this(1)
		{
			Helper.Report("Явно вызванный конструктор");
		}
		public void Method()
		{
			Helper.Report("Метод");
		}
	}

	class Program
	{
		public static void MainX()
		{
			Helper.Report("Начало программы");
			new MyClass().Method();
		}
	}
}
