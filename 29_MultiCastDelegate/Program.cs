using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _29_MultiCastDelegate
{
	public delegate void DelMethod(int x, int y);
	class Program
	{
		static void Main(string[] args)
		{
			
			MathOperations mathOperations = new MathOperations();
			DelMethod delmethod = new DelMethod(mathOperations.Sum);
			
			delmethod += new DelMethod(mathOperations.Substract); //Substract method add the chain 
			ForegroundColor = DarkGray;
			WriteLine("***** Call the Sum and Substract methods from the chain  ******");
			delmethod(20,30);  ///call the Sum and Substract methods
			
			delmethod += new DelMethod(mathOperations.Division); //Division method add the chain 
			delmethod += new DelMethod(mathOperations.Multiple); //Multiple method add the chain 
			ForegroundColor = DarkMagenta;
			WriteLine("***** Call the all methods from the chain  ******");
			delmethod(20, 30);  ///call the Sum, Substract, Multiple and  Division methods
			//remove the Multiple method from the chain
			ForegroundColor = DarkRed;
			WriteLine("***** remove the Multiple method from the chain  ******");
			delmethod -= new DelMethod(mathOperations.Division); //Division method add the chain 
			delmethod(20, 30);  ///call the Sum, Substract and  Division methods
			ReadKey();
		}
	}
}
