using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.IO.Compression;
using static System.Console;
using static System.ConsoleColor;
namespace _48_StreamIO.DirectoryInfo_
{
	class Program
	{
		static void Main(string[] args)
		{
			//var directoryInfo = Directory.GetDirectories;
			////DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\mypc\\source\\repos\\ConsoleApplications\\48_StreamIO.DirectoryInfo");
			//DirectoryInfom directoryInfo = new DirectoryInfom(@"C:\Users\mypc\source\repos\ConsoleApplications\48_StreamIO.DirectoryInfo");
			//foreach (DirectoryInfo di  in directoryInfo)
			//{

			//}
			DirectoryInfo di = new DirectoryInfo(@"C:\Users\mypc\source\repos\ConsoleApplications\48_StreamIO.DirectoryInfo");
			Console.WriteLine("No search pattern returns:");
			foreach (var fi in di.GetFiles())
			{
				Console.WriteLine(fi.Name);
			}
			ReadKey();

		}
	}
}
/*DirectoryInfo di = new DirectoryInfo("C:\\");
				DirectoryInfo[] klasorler = di.GetDirectories();
				foreach (DirectoryInfo klasor in klasorler)
				{
						ListBox1.Items.Add(klasor.Name);
				}
 
	 */
