using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
    class Program
    {
        static void MainX(string[] args)
        {

            //var binWriter = new BinaryWriter(File.Open("bin",FileMode.Create,FileAccess.Write));

            var memoryStream = new MemoryStream();
            var binWriter = new BinaryWriter(memoryStream);

            for (int i = 1; i <= 1024; i*=2)
                binWriter.Write(i);
            binWriter.Flush();

            int intLength = sizeof(int);
            var bytes = memoryStream.GetBuffer();
            for (int i=0;i<memoryStream.Position;i++)
            {
                if (i%intLength==0) Console.WriteLine();
                Console.Write("{0:X2} ", bytes[i]);
            }
            Console.WriteLine();

            
        }
    }
}
