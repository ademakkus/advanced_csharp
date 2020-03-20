using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_CheckedKeyword
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b1 = 100;
			byte b2 = 250;
			
			try
			{
				byte result =checked((byte)(b1+b2));
				//byte sum = checked((byte)Add(b1, b2));
				//byte sum = checked((byte)Add(b1, b2));
				Console.WriteLine("result is= {0}",result);
			}
			catch (OverflowException ex)
			{
				Console.WriteLine(ex.Message);
			}
		
			// sum should hold the value 350. However, we find the value 94!
			
			Console.ReadKey();
		}

	}

	//private static byte Add(byte b1, byte b2)
	//{

	//	try
	//	{
	//		//byte sum = checked((byte)Add(b1, b2));
	//		//byte sum = checked((byte)Add(b1, b2));
	//		Console.WriteLine("sum = {0}", sum);
	//	}
	//	catch (OverflowException ex)
	//	{
	//		Console.WriteLine(ex.Message);
	//	}
	//	return (byte)(b1 - b2);
	//}
}

