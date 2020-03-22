using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Predicate_With_Lambda_Expression
{
	class Point
	{
		private int _x;
		private int _y;

		public int X { get => _x; set => _x = value; }
		public int Y { get => _y; set => _y = value; }
		public Point(int x,int y)
		{
			this.X = x;
			this.Y = y;
		}
		public Point()
		{

		}
	}
}
