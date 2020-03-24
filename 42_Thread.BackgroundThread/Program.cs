using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;
using static System.Net.Mime.MediaTypeNames;

namespace _42_Thread.BackgroundThread
{
	class Program
	{
		static void Main(string[] args)
		{

			ForegroundColor = DarkGreen;
			Thread thread = new Thread(MyBackgroundThread);
			thread.Name = "Name : My Background Thread ";
			thread.IsBackground = true; //must be true for background
			thread.Start();
			
			//bool isAlive = thread.IsAlive;
			//WriteLine(isAlive);
			ForegroundColor = DarkGreen;
			WriteLine("Main thread ends");
		
			ForegroundColor = DarkGreen;
			//WriteLine("************dddddd");
			ReadKey();
			
		}
		static void MyBackgroundThread()
		{
			ForegroundColor = DarkYellow;
			for (int i = 0; i !=10; i++) //for (int i = 0; i <10; i++)
			{
				WriteLine("In progress thread is {0}", Thread.CurrentThread.Name);
				//WriteLine($"In progress thread is {Thread.CurrentThread.Name}");//with C# 6
			}
			Thread.Sleep(500);
			ForegroundColor = DarkRed;
			WriteLine("Completed thread is :{0}", Thread.CurrentThread.Name);
			//WriteLine($"Completed thread is :{Thread.CurrentThread.Name}"); //with C# 6
		}
	}
}
