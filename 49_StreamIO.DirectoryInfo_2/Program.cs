using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _49_StreamIO.DirectoryInfo_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Using Directory(Info) *****\n");
			ShowWindowsDirectoryInfo();
			DisplayImageFiles();
			ShowLogicalDrives();
			ReadKey();
			Console.ReadLine();
		}
		static void ShowWindowsDirectoryInfo()
		{
			ForegroundColor = DarkBlue;
			// Windows directory information.
			DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
			Console.WriteLine("***** Directory Info *****");
			Console.WriteLine("FullName: {0}", dir.FullName);
			Console.WriteLine("Name: {0}", dir.Name);
			Console.WriteLine("Parent: {0}", dir.Parent);
			Console.WriteLine("Creation: {0}", dir.CreationTime);
			Console.WriteLine("Attributes: {0}", dir.Attributes);
			Console.WriteLine("Root: {0}", dir.Root);
			Console.WriteLine("**************************\n");
			//Console.ReadKey();
		}
		/// <summary>
		/// 
		/// </summary>
		static void DisplayImageFiles()
		{
			ForegroundColor = DarkGreen;
			DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
			// Get all files with a *.jpg extension.
			FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
			// How many were found?
			Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
			// Now print out info for each file.
			ForegroundColor = DarkYellow;
			foreach (FileInfo f in imageFiles)
			{
				Console.WriteLine("***************************");
				Console.WriteLine("File name: {0}", f.Name);
				Console.WriteLine("File size: {0}", f.Length);
				Console.WriteLine("Creation: {0}", f.CreationTime);
				Console.WriteLine("Attributes: {0}", f.Attributes);
				Console.WriteLine("***************************\n");
			}
		}
		/// <summary>
		/// Show all logical drives
		/// </summary>
		static void ShowLogicalDrives()
		{
			ForegroundColor = DarkRed;
			WriteLine("*** Here all logical drives ***");
			string[] logicalDrives = Directory.GetLogicalDrives();
			StringBuilder stringBuilder = new StringBuilder();
			foreach (var drive in logicalDrives)
			{
				stringBuilder.AppendLine(drive);
			}
			WriteLine(stringBuilder);
		}
	}
}
