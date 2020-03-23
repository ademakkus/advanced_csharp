using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Console;
namespace _38_Excel_Interop
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Car> carInStock = new List<Car>
			{
				new Car{Color="Green",Make="VW",PetName="Mary"},
				new Car{Color="Red",Make="Saab",PetName="Mel"},
				new Car{Color="Black",Make="Ford",PetName="Halk"},
				new Car{Color="Yellow",Make="BMW",PetName="Davie"}
			};
			ExportToExcel(carInStock);
			ReadKey();

		}
		static void ExportToExcel(List<Car> carsInStock)
		{
			Excel.Application application = new Excel.Application();
			application.Workbooks.Add();
			Excel._Worksheet worksheet = application.ActiveSheet;
			worksheet.Cells[1, "A"] = "Make";
			worksheet.Cells[1, "B"] = "Color";
			worksheet.Cells[1, "C"] = "Pet Name";
			int row = 1;
			foreach (Car car in carsInStock)
			{
				row++;
				worksheet.Cells[row, "A"] =car.Make;
				worksheet.Cells[row, "B"] =car.Color;
				worksheet.Cells[row, "C"] =car.PetName;


			}
			worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
			worksheet.SaveAs($@"{Environment.CurrentDirectory}\Inventory.xlsx");
			WriteLine("The Inventory.xslx file has been saved to your app folder");
			application.Visible = true;
			

		}
	}
}
