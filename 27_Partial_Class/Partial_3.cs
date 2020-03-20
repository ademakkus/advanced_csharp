using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Partial_Class
{
	
	public partial class Person
	{
		public void AddPerson()
		{


		}
		public Person(string name,string surname,int age)
		{
			this.Name = name;
			this.Surname = surname;
			this.Age = age;
			
		}
	}
}
