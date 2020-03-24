using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;
namespace _45_Thread.MultiThread
{
	public class ThreadObject
	{
		public void FirstThread()
		{
			
			for (int i = 0; i!=10; i++)
			{
				ForegroundColor = DarkBlue;
				WriteLine("First Thread ");
				Thread.Sleep(500);
			}
		}
		public void SecondtThread()
		{
			
			for (int i = 0; i != 10; i++)
			{
				ForegroundColor = DarkGreen;
				WriteLine("Second Thread ");
				Thread.Sleep(500);
			}
		}
		public void ThridThread()
		{
			
			for (int i = 0; i != 10; i++)
			{
				ForegroundColor = DarkYellow;
				WriteLine("Third Thread ");
				Thread.Sleep(500);
			}
		}
	}
}
