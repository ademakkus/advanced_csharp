using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console; //import static System.out; in java
using static System.ConsoleColor;
namespace _56_DateTime_Formats
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);

			ForegroundColor = DarkBlue;
			WriteLine("Now Time ****");
			Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
			Console.WriteLine("{0:d.MM.yy}", DateTime.Now);
			ForegroundColor = DarkGreen;
			WriteLine("Special time ****");
			Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
			ForegroundColor = DarkYellow;
			Console.WriteLine("{0:d.MM.yy}", d);
			ForegroundColor = DarkRed;
			WriteLine();
			//Turkish culture format
			WriteLine("C* Turkish culture format");
			Thread.CurrentThread.CurrentCulture =CultureInfo.GetCultureInfo("tr-TR");
			Console.WriteLine("{0:N}", 1234.56);
			Console.WriteLine("{0:D}", d);

			Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
			Console.WriteLine("{0:N}", 1234.56);
			Console.WriteLine("{0:D}", d);
			Beep(500, 3000);
			Console.ReadKey();
		}
	}
}
