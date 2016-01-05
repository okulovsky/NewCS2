using System;
namespace Slide03
{
    class Program
    {
        public static void MainX()
        {
            for (int i = 0; i < 20; i++)
            {
                var bytes = new byte[1000000];
                Console.WriteLine(GC.GetTotalMemory(false));
                //GC.Collect();
                //этот метод выводит количество доступной памяти
                //видно, что она освобождается
            }

        }
    }
}