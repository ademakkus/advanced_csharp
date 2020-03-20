using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _26_base_Constructor
{
	public class Bird
	{
		public int value;

		public Bird(int value)
		{
			WriteLine($"Bird() constructor called:{value} ");
		}
	}
	class Parrot:Bird
	{
	
			public Parrot(int value):base(value)
			{
			WriteLine($"Parrot() constructor called value :{value}");
			}
		
	}
}
