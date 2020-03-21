using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _30_GenericDelegate
{
	public delegate void MyGenericDelegate<T>(T arg); //call the void and single parameter methods
	class Program
	{
		/// <summary>
		/// Void return type
		/// </summary>
		/// <param name="arg">string type argument</param>
		static void StringTarget(string arg)
		{
			WriteLine($"arg in upper case {arg.ToUpper()}"); //with c# 6 
			//WriteLine("arg in uppaercase{0}",arg);

		}
		// <summary>
		/// Void return type
		/// </summary>
		/// <param name="arg">int type argument</param>
		static void IntTarget(int arg)
		{
			WriteLine($"++arg in {++arg}"); //with c# 6 
		//WriteLine($"++arg in uppaercase{++arg}");
		}
		// <summary>
		/// Void return type
		/// </summary>
		/// <param name="arg">double type argument</param>
		static void DoubleTarget(double arg)
		{
			WriteLine($"++arg in double {(double)1.25+arg}"); //with c# 6 
		}
		static void Main(string[] args)
		{
			//string type  delegate
			MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
			strTarget("Some string data...");
			//int type delegate
			MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
			//MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(Program.IntTarget);
			intTarget(229);
			//double type delegate

			MyGenericDelegate<double> doubleTarget = new MyGenericDelegate<double>(DoubleTarget);
			doubleTarget(12.200);
			ReadKey();
		}
	}
}
