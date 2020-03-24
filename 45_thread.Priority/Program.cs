using _45_Thread.MultiThread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _45_thread.Priority
{
	class Program
	{
		static void Main(string[] args)
		{
			ThreadObject threadObject = new ThreadObject();
			Thread threadFirst = new Thread(new ThreadStart(threadObject.FirstThread));
			Thread threadSecond = new Thread(new ThreadStart(threadObject.SecondtThread));
			Thread threadThird = new Thread(new ThreadStart(threadObject.ThridThread));
			threadFirst.Priority = ThreadPriority.Lowest;
			threadSecond.Priority = ThreadPriority.Normal;
			threadThird.Priority = ThreadPriority.Highest;
			//threadFirst.Join();
			threadFirst.Start();
			threadSecond.Start();
			threadThird.Start();
			ForegroundColor = DarkMagenta;
			WriteLine("Main thread ends..");
			ReadKey();
		}
	}
}
