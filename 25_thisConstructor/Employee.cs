using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_thisConstructor
{
	class Employee
	{
		// private fields
		private string _empName;
		private int _empId;
		private int _empAge;
		private float _empPay;
		//properties
		public string EmpName { get => _empName; set => _empName = value; }
		public int EmpId { get => _empId; set => _empId = value; }
		public int EmpAge { get => _empAge; set => _empAge = value; }
		public float EmpPay { get => _empPay; set => _empPay = value; }
		//constructors
		/// <summary>
		/// this constructor
		/// </summary>
		public Employee() : this("Adem", 3, 0,2500) { }
		/// <summary>
		/// Employee constructor
		/// </summary>
		/// <param name="name">employee name</param>
		/// <param name="id">employee id</param>
		/// <param name="age">employee age</param>
		/// <param name="pay">employee pay</param>
		public Employee(string name, int id, int age, float pay) {
			this.EmpName = name;
			this.EmpId = id;
			this.EmpAge = age;
			this.EmpPay = pay;
			Console.WriteLine($"Employee, Name={EmpName}, ID={EmpId}, Age={EmpAge} and Pay ={EmpPay}");
		}
	}
}
