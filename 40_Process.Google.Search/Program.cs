using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using static System.ConsoleColor;
namespace _40_Process.Google.Search
{
	class Program
	{
		
		static void Main(string[] args)
		{

			SearchGoogle("adem akkuş");
			ReadKey();
		}
		static void SearchGoogle(string term)
		{
			Process.Start("http://google.com/search?q=" + term);
		}
	}
}
