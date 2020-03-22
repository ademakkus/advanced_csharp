using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _37_Predicate_With_Lambda_Expression
{
	class Program
	{
		static void Main(string[] args)
		{

			Point[] points = { new Point(100, 250),new Point(150,250),new Point(250,375),new Point(275,395),new Point(295,450) };
			Point point = Array.Find(points,
				x=>x.X*x.Y>100000
				);
			WriteLine("Found X= {0}, Y = {1}", point.X, point.Y);
			ReadKey();

		}
	}
}
