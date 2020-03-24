using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _43_Thread.Join
{
	public class ThreadObject
	{
		public void MyThreadFirst()
		{
			ForegroundColor = DarkBlue;
			for (int i = 0; i!=10; i++)
			{
				WriteLine($"First thread step {i} is running ");
				Thread.Sleep(500);
			}
		}
		public void MyThreadSecond()
		{
		
			ForegroundColor = DarkGreen;
			
				WriteLine("Second  thread is running ");

		}
	}
}
