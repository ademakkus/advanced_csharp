using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _46_Process.ShowRunningProcesses
{
	class Program
	{
		static void Main(string[] args)
		{

			var runingProcesses = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
			foreach (var p in runingProcesses)
			{
				string info = $"-->PID:{p.Id}\tName:{p.ProcessName}\tMachine Name : {p.MachineName}";
				WriteLine(info);

			}
			
			ReadKey();
		}
	}
}
/*
 * var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
// Print out PID and name of each process.
foreach(var p in runningProcs)
{
string info = $"-> PID: {p.Id}\tName: {p.ProcessName}",
Console.WriteLine(info);
}
Console.WriteLine("************************************\n");
}
 */
