using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;


namespace _35_Action_With_Anonymous_Method
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string, ConsoleColor, int> DisplayMessage =
				delegate (string message, ConsoleColor textColor, int printCount)
				{
					ConsoleColor previousColor = Console.ForegroundColor;
					Console.ForegroundColor = textColor;
					for (int i = 0; i < printCount; i++)
					{
						WriteLine(i+1+" . "+message);
					}
					Console.ForegroundColor = previousColor;
					//Restore text color(Console.ForegroundColor) property
					WriteLine("Restore text color");
				};
			DisplayMessage("Delegate message 1",ConsoleColor.DarkGreen,20);

			ReadKey();
		}
	}
}

