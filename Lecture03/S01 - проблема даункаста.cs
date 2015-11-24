using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide01
{
    class Program
    {
        static void MainX(string[] args)
        {
			var objArray = new ArrayList();
			objArray.Add(1);
			objArray.Add(2);
			objArray.Add("3");
			var sum=0;
			foreach (int e in objArray)
				sum += e;

			var intArray = new List<int>();
			intArray.Add(1);
			intArray.Add(2);
			//sintArray.Add("3");
			sum = 0;
			foreach (var e in intArray)
				sum += e;
			
        }
    }
}
