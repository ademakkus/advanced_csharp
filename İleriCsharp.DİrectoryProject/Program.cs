using System;
using System.IO;
using static System.Console;
namespace İleriCsharp.DİrectoryProject
{
	class Program
	{
		static void Main(string[] args)
		{

			Directory.CreateDirectory(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp");
			WriteLine(Directory.GetCreationTime(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp\data\test1"));

			Directory.CreateDirectory(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp\İleriCsharp.DİrectoryProject\data\test2");
			WriteLine(Directory.GetCreationTime(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp\data\test2"));

			ReadKey();
		}
	}
}
