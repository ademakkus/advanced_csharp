using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;
namespace _41_Thread.ForegroundThread
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Thread thread = new Thread(MyForegroundThread);
			
			thread.Start();
			ForegroundColor = DarkYellow;
			WriteLine("Main() thread ends..");
			ReadKey();
		}
		static void MyForegroundThread()
		{
			ForegroundColor = DarkGreen;
			for (int i = 0; i != 10; i++)
			//for (int i = 0; i != 10; i++)
			{
				WriteLine(i+"MyForegroundThread() is in progress...");
				Thread.Sleep(500);

			}
			ForegroundColor = DarkRed;
			WriteLine("MyForegroundThread() ends...");
		
		}
	}
}
