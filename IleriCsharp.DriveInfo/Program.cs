using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace IleriCsharp.DriveInfoProject
{
	class Program
	{
		static void Main(string[] args)
		{

			foreach (var driveInfo in DriveInfo.GetDrives())
			{
				WriteLine("*********************");
				WriteLine("DriverType : " + driveInfo.DriveType);
				if (driveInfo.IsReady)
				{
					WriteLine("Name : " + driveInfo.Name);
					WriteLine("RootDirectory : " + driveInfo.RootDirectory);
					WriteLine("TotalFreeSpace : " + driveInfo.TotalFreeSpace);
				}

			}
			ReadKey();
		}
	}
}
