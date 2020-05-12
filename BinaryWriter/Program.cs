using System;
using System.IO;
using System.Runtime.InteropServices;
using static System.Console;


namespace İleriCsharp.BinaryWriterProject
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryWriter binaryWriter = null;

			try
			{
				binaryWriter = new BinaryWriter(new FileStream(@"C:\Users\mypc\source\repos\KocaAkademi.İleriCsharp\BinaryWriter\data", FileMode.Open));
				binaryWriter.Write("BinaryWriter ile yazılan data \n");
				binaryWriter.Write(DateTime.Now.ToString());
			}
			catch (Exception exc)
			{

				throw exc;
			}

			finally
			{
				if (binaryWriter!=null)
				{
					binaryWriter.Close();
					binaryWriter.Dispose();
				}
			}
			Console.ReadKey();
			
		}
	}
}
