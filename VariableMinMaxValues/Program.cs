using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableMinMaxValues
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Data type Functionality:");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("Max of int: {0}", int.MaxValue);
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("Min of int: {0}", int.MinValue);
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("Max of double: {0}", double.MaxValue);
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("Min of double: {0}", double.MinValue);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
			Console.WriteLine("double.PositiveInfinity: {0}",
double.PositiveInfinity);
			Console.WriteLine("double.NegativeInfinity: {0}",
			double.NegativeInfinity);
			Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
			Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
