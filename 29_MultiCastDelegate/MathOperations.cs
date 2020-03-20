using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _29_MultiCastDelegate
{
	public class MathOperations
	{
		/// <summary>
		/// Sum method
		/// </summary>
		/// <param name="number1">first number</param>
		/// <param name="number2">second number</param>
		public void Sum(int number1,int number2) {
			ForegroundColor = DarkBlue;
			WriteLine("\nYou are in Sum method");
			WriteLine($"Sum result  is :{number1 + number2} ");
		}
		/// <summary>
		/// Substract method
		/// </summary>
		/// <param name="number1">first number</param>
		/// <param name="number2">second number</param>
		public void Substract(int number1, int number2)
		{
			ForegroundColor = DarkGreen;
			WriteLine("\nYou are in Substract method");
			WriteLine($"Substarct result  is :{number1 - number2} ");
		}

		/// <summary>
		/// Multiple method
		/// </summary>
		/// <param name="number1">first number</param>
		/// <param name="number2">second number</param>
		public void Multiple(int number1, int number2)
		{
			ForegroundColor = DarkCyan;
			WriteLine("\nYou are in Multiple method");
			WriteLine($"Multiple result  is :{number1 * number2} ");
		}

		/// <summary>
		/// Division method
		/// </summary>
		/// <param name="number1">first number</param>
		/// <param name="number2">second number</param>
		public void Division(int number1, int number2)
		{
			ForegroundColor = DarkYellow;
			WriteLine("\nYou are in Sum method");
			WriteLine($"Substarct result  is :{(int)(number1 / number2)} ");
		}
	}
}
