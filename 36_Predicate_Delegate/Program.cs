using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;


namespace _36_Predicate_Delegate
{
	class Program
	{
		static void Main(string[] args)
		{
			Point[] points ={new Point(100,200),
												new Point(150, 250),
													new Point(250, 375),
												 new Point(275, 395),
													new Point(295, 450) };
			Predicate<Point> predicate = FindPoints;
			Point first = Array.Find(points, predicate);
			WriteLine("Found : X={0}, Y= {1}",first.X,first.Y);
			ReadKey();
		}
		private static bool FindPoints(Point obj)
		{
			return obj.X * obj.Y > 100000;

		}
	}
}
