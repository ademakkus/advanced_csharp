using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _50_Regex
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkBlue;
			WriteLine("Hello Regex Application");
			string pattern = @"\d";
			Regex regex = new Regex(pattern);
			string text = "This is usign text for regex 12345678";
			MatchCollection matchCollection = regex.Matches(text);
			ForegroundColor = DarkCyan;
			WriteLine("{0} hits found :\n{1}", matchCollection.Count, text);
			ForegroundColor = DarkYellow;
			foreach (Match hit in matchCollection)
			{
				GroupCollection groupCollection = hit.Groups;
				WriteLine("{0} found at {1}", groupCollection[0].Value, groupCollection[0].Index);
			}
			ReadKey();
		}
	}
}
