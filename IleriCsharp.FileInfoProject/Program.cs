using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace IleriCsharp.FileInfoProject
{
	class Program
	{
		static void Main(string[] args)
		{
			//string path = Assembly.GetEntryAssembly().Location; //exe ya da dll dosyasının yolunu verir
		
			string path= Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var filePath = path +"\\deneme.txt";
			var fileName = Path.GetFileName(filePath);
			WriteLine(path);
			WriteLine(filePath);
			FileInfo fileInfo = new FileInfo(@filePath);
			if (!fileInfo.Exists)
			{
				WriteLine("Creation Time :" + fileInfo.CreationTime);
				WriteLine("Direcory Name :" + fileInfo.DirectoryName);
				//WriteLine("File length :" + fileInfo.Length);
				WriteLine("File Extension :" + fileInfo.Extension);
			}

			ReadKey();
		}
	}
}
