using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace IleriCsharp.CustomAttribute
{
public static	class KullaniciKontrol
	{
		public static bool Kontrol(Kullanici kullanici)
		{
			var retVal = true;
			//
			var properties = kullanici.GetType().GetProperties();
			foreach (var propertyInfo in properties)
			{
				if (propertyInfo.GetCustomAttributes(typeof(BosOlamazAttribute), true).Any())
				{
					var val = propertyInfo.GetValue(kullanici) as string;
					if (string.IsNullOrEmpty(val))
					{
						retVal = false;
					}
				}
			}
			return retVal;

		}
	}
}
