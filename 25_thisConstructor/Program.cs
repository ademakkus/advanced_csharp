using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _25_thisConstructor
{
	
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkYellow;
			WriteLine("This constructor");
			Employee employee = new Employee();
			ForegroundColor = DarkGreen;
			WriteLine("Normal Constructor");
			Employee employee1 = new Employee("Furkan",4,11,2500);
			ReadKey();
		}
	}
}
