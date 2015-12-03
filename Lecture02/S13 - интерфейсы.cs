using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide06
{
	interface IFigure
	{
		Point Location { get; set; }
		abstract bool Contains(Point p);
		abstract double Area { get; }
		
	}

	class Square : IFigure
	{
		public Point Location { get; set; }
		public int Size { get; set; }
		public override bool Contains(Point p)
		{
			return 
				Math.Abs(p.X - Location.X) < Size/2 && 
				Math.Abs(p.Y - Location.Y) < Size / 2;
		}
		public override double Area
		{
			get
			{
				return Math.Pow(Size, 2);
			}
		}
	}

	class Circle : IFigure
	{
		public Point Location { get; set; }
		public int Radius { get; set; }
		public override bool Contains(Point p)
		{
			return
				Math.Sqrt(Math.Pow(p.X - Location.X, 2) + Math.Pow(p.Y - Location.Y, 2)) < Radius;
		}
		public override double Area
		{
			get
			{
				return Math.PI * Math.Pow(Radius, 2);
			}
		}
	}


    public class Program
    {
        static void MainX(string[] args)
        {
			var scene = new List<IFigure>
			{
				new Square { Location=new Point(0,0), Size=2 },
				new Circle { Location=new Point(1,1), Radius=3 }
			};

			var point = new Point(1, 0);
			foreach (var e in scene)
				Console.WriteLine(e.Contains(point));

			foreach (var e in scene)
				Console.WriteLine(e.Area);
        }
    }
}
