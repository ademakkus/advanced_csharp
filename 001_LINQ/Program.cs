using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _001_LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Car> myCars = new List<Car>()
			{


				new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
			new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
		};
			GetFastCars(myCars);
			GetFastBMWs(myCars);
			ReadKey();

		}
		static void	GetFastCars(List<Car> myCars)
		{

			var fastCars = from c in myCars where c.Speed > 55 select c;
			foreach (var car in fastCars)
			{
				WriteLine("{0} is going too fast !", car.PetName); 
				//WriteLine($"{car.PetName} is going too fast !"); //with c#6

			}
		}
		static void GetFastBMWs(List<Car> myCars)
		{

			var fastCars = from c in myCars where c.Speed > 55 && c.Make=="Bmw".ToUpper() select c;
			foreach (var car in fastCars)
			{
				WriteLine("{0} is going too fast !", car.PetName);
				//WriteLine($"{car.PetName} is going too fast !"); //with c#6

			}
		}
	}
}
