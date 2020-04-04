using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.Design;
using System.ServiceProcess;
using System.ComponentModel;
using static System.Console;
using static System.ConsoleColor;

namespace _47_Process.ProcessThread.Set
{
	class Program
	{
		static void Main(string[] args)
		{
			// Prompt user for a PID and print out the set of active threads.
Console.WriteLine("***** Enter PID of process to investigate *****");
			Console.Write("PID: ");
			string pID = Console.ReadLine();
			int theProcID = int.Parse(pID);
			EnumThreadForPid(theProcID);
			Console.ReadLine();
		}

		static void EnumThreadForPid(int processId)
		{
			Process theProcess = null;
			try
			{
				theProcess = Process.GetProcessById(processId);
			}
			catch (ArgumentException exc)
			{

				WriteLine(exc.Message);
				return;
			}
			// List out stats for each thread in the specified process.
			Console.WriteLine("Here are the threads used by: {0}", theProcess.ProcessName);
			ProcessThreadCollection theThreads = theProcess.Threads;
			//foreach (ProcessThread pt in theThreads)
			//{
			//	string info =$"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority:{pt.PriorityLevel}";
			//Console.WriteLine(info);
			//}
			//Console.WriteLine("************************************\n");
		}
	}
}
/*

	*/
