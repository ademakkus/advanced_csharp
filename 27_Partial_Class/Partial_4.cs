using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Partial_Class
{
	public partial class Person
	{
		public Person()
		{
				
		}
		public Person(Person person)
		{
			PersonRegisterProp = person;
		}
	}
}
