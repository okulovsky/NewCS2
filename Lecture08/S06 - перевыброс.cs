using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide06
{

    class AlgorithmException : Exception
    {
        public AlgorithmException(Exception innerException)
            : base("", innerException)
        { }
    }

    class Program
    {
        static void MainX(string[] args)
        {
            int importantParameter;
            try
            {
                importantParameter = int.Parse(File.ReadAllText("text.txt"));
            }
            catch(Exception e)
            {
                throw new AlgorithmException(e);
            }
        }
    }
}
