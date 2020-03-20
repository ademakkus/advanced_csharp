using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> System.Object Functionality:");
			// A C# int is really a shorthand for System.Int32,
			// which inherits the following members from System.Object.
			Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("12.ToString() = {0}", 12.ToString());
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("12.GetType() = {0}", 12.GetType());
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
