using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.String_Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Length This property returns the length of the current string.
Compare() This static method compares two strings.
Contains() This method determines whether a string contains a specific substring.
Equals() This method tests whether two string objects contain identical character data.
Format() This static method formats a string using other primitives (e.g., numerical data,
other strings) and the {0} notation examined earlier in this chapter.
Insert() This method inserts a string within a given string.
PadLeft() These methods are used to pad a string with some characters.
PadRight()
Remove() These methods are used to receive a copy of a string with modifications (characters
removed or replaced).
Replace()
Split() This method returns a String array containing the substrings in this instance that
are delimited by elements of a specified char array or string array.
Trim() This method removes all occurrences of a set of specified characters from the
beginning and end of the current string.
ToUpper() These methods create a copy of the current string in uppercase or lowercase format,
respectively.
ToLower()
			 * */
			Console.WriteLine("=> Basic String functionality:");
			string firstName = "Ademmed";
			Console.WriteLine("Value of firstName: {0}", firstName);
			Console.WriteLine("firstName has {0} characters.", firstName.Length);
			Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
			Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
			Console.WriteLine("firstName contains the letter y?: {0}",			firstName.Contains("y"));
			Console.WriteLine("firstName contains the letter m?: {0}",			firstName.Contains("m"));
			Console.WriteLine("firstName after replace: {0}", firstName.Replace("med", ""));
			Console.WriteLine();
			Console.ReadKey();

		}
	}
}
