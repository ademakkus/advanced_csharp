using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _28_Delegate
{
	public delegate void delmethod();
	public class P
	{
		public static void display()
		{
			ForegroundColor = DarkBlue;
			Console.WriteLine();
			Console.WriteLine("Hello!");
		}
		public static void show()
		{
			ForegroundColor = DarkGray;
			Console.WriteLine();
			Console.WriteLine("Hi!");
		}
		public void print()
		{
			ForegroundColor = DarkGreen;
			Console.WriteLine();
			Console.WriteLine("Print");
		}

	}
	class Program
	{
static void Main(string[] args)
		{
			// here we have assigned static method show() of class P to delegate delmethod()
			delmethod del1 = P.show;
			// here we have assigned static method display() of class P to delegate delmethod() using new operator
			// you can use both ways to assign the delagate
			delmethod del2 = new delmethod(P.display);
			P obj = new P();
		// here first we have create instance of class P and assigned the method print() to the delegate i.e. delegate with class    
			delmethod del3 = obj.print;
			del1();
			del2();
			del3();
			Console.ReadLine();
		}
	}
}
