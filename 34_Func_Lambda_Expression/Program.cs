using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _34_Func_Lambda_Expression
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, int> Add = (x, y) => x + y;
			int intResult = Add(25, 35);
			WriteLine($"25+35={intResult}");
			Func<int, int, string> SumToString = (x, y) => (x + y).ToString();
			string stringResult = SumToString(100,50);
			WriteLine("100+50  = {0}",stringResult);
			ReadKey();

		}
	}
}
