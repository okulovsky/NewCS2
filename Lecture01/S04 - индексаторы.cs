﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    public class MyClass
    {
		public int this[int index]
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}
		
		public static void Main()
		{
			var obj = new MyClass();
			obj[10] = 10;
		}
    }
}
