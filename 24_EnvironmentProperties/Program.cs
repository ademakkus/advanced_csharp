using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EnvironmentProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			


		 
				string str;
				string nl = Environment.NewLine;
			//
			Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine();
				Console.WriteLine("--** Environment Members - Üyeleri ******--");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			//  Invoke this sample with an arbitrary set of command line arguments.
			Console.WriteLine("CommandLine: {0}", Environment.CommandLine);

				string[] arguments = Environment.GetCommandLineArgs();
				Console.WriteLine("GetCommandLineArgs: {0}", String.Join(", ", arguments));

				//  <-- Keep this information secure! -->
				Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

				Console.WriteLine("ExitCode: {0}", Environment.ExitCode);

				Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);

				//  <-- Keep this information secure! -->
				Console.WriteLine("MachineName: {0}", Environment.MachineName);

				Console.WriteLine("NewLine: {0}  first line{0}  second line{0}  third line",
															Environment.NewLine);

				Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

				Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);

				//  <-- Keep this information secure! -->
				Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);

				Console.WriteLine("TickCount: {0}", Environment.TickCount);

				//  <-- Keep this information secure! -->
				Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);

				Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);

				//  <-- Keep this information secure! -->
				Console.WriteLine("UserName: {0}", Environment.UserName);

				Console.WriteLine("Version: {0}", Environment.Version.ToString());

				Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);

				//  No example for Exit(exitCode) because doing so would terminate this example.

				//  <-- Keep this information secure! -->
				string query = "My system drive is %SystemDrive% and my system root is %SystemRoot%";
				str = Environment.ExpandEnvironmentVariables(query);
				Console.WriteLine("ExpandEnvironmentVariables: {0}  {1}", nl, str);

				Console.WriteLine("GetEnvironmentVariable: {0}  My temporary directory is {1}.", nl,
															 Environment.GetEnvironmentVariable("TEMP"));
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("GetEnvironmentVariables: ");
				IDictionary environmentVariables = Environment.GetEnvironmentVariables();
				foreach (DictionaryEntry de in environmentVariables)
				{
					Console.WriteLine("  {0} = {1}", de.Key, de.Value);
				}

				Console.WriteLine("GetFolderPath: {0}",
										 Environment.GetFolderPath(Environment.SpecialFolder.System));
			Console.ForegroundColor = ConsoleColor.DarkGray;
			string[] drives = Environment.GetLogicalDrives();
				Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives));
			Console.ReadKey();
			}
		}
	 
	}
