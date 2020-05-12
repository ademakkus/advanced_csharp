using System;
using System.IO;
using static System.Console;
namespace İleriCsharp.BinaryeaderProject
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryReader binaryReader;
			try
			{
				binaryReader = new BinaryReader(new FileStream(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp\İleriCsharp.BinaryeaderProject\data", FileMode.Open));
				WriteLine(binaryReader.ReadString());
			
			}
			catch (Exception exc)
			{

				throw exc;
			}
		
			


			ReadKey();
		}
	}
}
