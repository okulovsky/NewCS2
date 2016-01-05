using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    class Program
    {
        public static void MainX(string[] args)
        {
            var textWriter = new StreamWriter("text");
            textWriter.WriteLine("Привет, мир!");
            textWriter.Flush();
            textWriter.WriteLine("Привет еще раз");
            textWriter.Close();

            var textReader = new StreamReader("text");
            while(true)
            {
                var str = textReader.ReadLine();
                if (str == null) break;
                Console.WriteLine(str);
            }
            textReader.Close();

            var binWriter = new BinaryWriter(File.Open("bin",FileMode.Create,FileAccess.Write));
            for (int i = 1; i <= 1024; i*=2)
                binWriter.Write(i);
            binWriter.Close();

            int intLength = sizeof(int);
            var bytes=File.ReadAllBytes("bin");
            for (int i=0;i<bytes.Length;i++)
            {
                if (i%intLength==0) Console.WriteLine();
                Console.Write("{0:X2} ", bytes[i]);
            }
            Console.WriteLine();
            
        }
    }
}
