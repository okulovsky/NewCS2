using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    class Program
    {
        static void MainX(string[] args)
        {
            int notImportantParameter;
            try
            {
                notImportantParameter = int.Parse(File.ReadAllText("test.txt"));
            }
            catch
            {
                notImportantParameter = 1;
            }
            /// ... algorithm continues
        }
    }
}
