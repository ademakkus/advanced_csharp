using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _33_Func_With_Anonymous_Method
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, int> Add = delegate (int x, int y)
			{
				return x + y;
			};
			int result = Add(25, 35);
			WriteLine("25+35={0}", result);
			///WriteLine($"25+35={result}");

			Func<int, int, string> SumToString = delegate (int x, int y)
			{
				return (x + y).ToString();
			};
			int stringresult = Add(56, 35);
			WriteLine("25+35={0}", stringresult);
			///WriteLine($"25+35={stringresult}"); //c#6 
			ReadKey();
		}
	}
}
