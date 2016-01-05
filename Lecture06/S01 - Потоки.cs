using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide01
{
    class Program
    {
        static void MainX(string[] args)
        {
            File.WriteAllText("text", "Привет, мир!");
            Console.WriteLine(File.ReadAllText("text"));

            var textWriter = new StreamWriter("text");
            textWriter.WriteLine("Строка 1");
            textWriter.WriteLine("Строка 2");
            textWriter.Flush();
            textWriter.WriteLine("Строка 3");
            textWriter.Close();

            var textReader = new StreamReader("text");
            while (true)
            {
                var str = textReader.ReadLine();
                if (str == null) break;
                Console.WriteLine(str);
            }
            textReader.Close();
        }
    }
}
