using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _31_Action_Delegate
{
	class Program
	{
		static void DisplayMessage(string message,ConsoleColor textColor,int printCount)
		{
			// Set color of console text.
			ConsoleColor previousColor = Console.ForegroundColor;
			//change text color(Console.ForegroundColor) property
			Console.ForegroundColor = textColor;
			for (int i = 0; i < printCount; i++)
			{
				WriteLine(i+1+"."+message);

			}
			//Restore text color(Console.ForegroundColor) property
			Console.ForegroundColor = previousColor;
			Console.WriteLine("ForegroundColor property chnaged");

		}
		static void Main(string[] args)
		{
			Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(DisplayMessage);

			action("Delegate message", ConsoleColor.DarkYellow, 10);
			WriteLine("After delegate");
			ReadKey();
		}
	}
}
