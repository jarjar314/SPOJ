using System;
using System.Globalization;

namespace SPOJ
{
	public class GNY07B
	{
		public GNY07B ()
		{
			int test = int.Parse (Console.ReadLine ());
			for (int i = 1; i <= test; i++) {
				string[] s = Console.ReadLine ().Split (' ');
				decimal nb = decimal.Parse (s [0], System.Globalization.NumberStyles.AllowDecimalPoint,	CultureInfo.InvariantCulture);
				string unit = s [1];
				if (unit == "kg")
					Console.WriteLine("{0} {1} {2}", i, decimal.Round(nb*2.2046m, 4).ToString(CultureInfo.InvariantCulture), "lb");
				else if (unit == "lb")
					Console.WriteLine("{0} {1} {2}", i, decimal.Round(nb*0.4536m, 4).ToString(CultureInfo.InvariantCulture), "kg");
				else if (unit == "l")
					Console.WriteLine("{0} {1} {2}", i, decimal.Round(nb*0.2642m, 4).ToString(CultureInfo.InvariantCulture), "g");
				else if (unit == "g")
					Console.WriteLine("{0} {1} {2}", i, decimal.Round(nb*3.7854m, 4).ToString(CultureInfo.InvariantCulture), "l");
			}
		}
	}
}

