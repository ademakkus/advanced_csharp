using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
using System.Threading;
namespace _43_Thread.Join
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkRed;
			ThreadObject threadObject = new ThreadObject();
			Thread threadFirst = new Thread(new ThreadStart(threadObject.MyThreadFirst));
			Thread threadSecond = new Thread(new ThreadStart(threadObject.MyThreadSecond));
		
			//threadFirst.IsBackground = TreatControlCAsInput; 
			threadFirst.Start();
			threadFirst.Join();
			//threadSecond.IsBackground = true;
			threadSecond.Start();
			Thread.Sleep(3000);
			ForegroundColor = DarkGray;

			WriteLine("Main thread ends..");
			ReadKey();
		}
	}
}
