using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Partial_Class
{
	public partial class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public List<Person> Persons { get; }
		public Person PersonRegisterProp
		{
			set
			{
				person.Add(value);
			}
		}
	}
}
