using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public static class SillyConverter
	{
		public static double SillyDouble(string s1, string s2)
		{
			double d1 = 0.0, d2 = 0.0;
			if (!String.IsNullOrEmpty(s1))
				d1 = Convert.ToDouble(s1);
			if (!String.IsNullOrEmpty(s2))
				d2 = Convert.ToDouble(s2);
			while(d2 >= 1)
			{
				d2 /= 10;
			}
			double d = d1 + d2;
			return d;
		}

		public static int SillyInt(string s)
		{
			int i = 0;
			if (!String.IsNullOrEmpty(s))
				i = Convert.ToInt32(s);
			return i;
		}
	}
}
