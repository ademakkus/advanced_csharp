using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _32_Func_Delegate
{
	class Program
	{
		 
		static int Add(int x,int y)
		{
			return x + y;
		}
		static string SumToString(int x,int y) {
			return (x + y).ToString(); 
		}
			
		static void Main(string[] args)
		{
			Func<int, int, int> funcTarget1 = new Func<int, int, int>(Add);
			
			int result = funcTarget1(25,35);
			WriteLine("25+35={0}",result);
			///WriteLine($"25+35={result}");

			Func<int, int, string> functTarget2 = new Func<int, int, string>(SumToString);
			
			string stringresult =functTarget2(56,35);
			WriteLine("56+35={0}", stringresult);
			///WriteLine($"25+35={stringresult}"); //c#6 
			ReadKey();
		}
	}
}
