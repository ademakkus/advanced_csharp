using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDefaultValue
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("=> Using new to create variables:");
			bool b = new bool(); // Set to false.
			int i = new int(); // Set to 0.
			double d = new double(); // Set to 0.
			DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("bool default value is: {0},\n" +
				"int efault value is: {1},\n" +
		"double efault value is: {2}, \n" +
	"DateTime efault value is:{3}", b, i, d, dt);
			///Console.WriteLine();
			Console.ReadKey();

		}
	}
}
