using System;
using System.Collections.Generic;

namespace SPOJ
{
	public class COINS
	{
		public COINS ()
		{
			Dictionary<long,long> conversion = new Dictionary<long, long> ();
			conversion [1] = 1;
			conversion [2] = 2;
			string line = Console.ReadLine ();
			while (!string.IsNullOrEmpty (line)) {
				long coin = long.Parse (line);
				Console.WriteLine (Conversion (coin, conversion));
			}
		}

		public static long Conversion (long coin, Dictionary<long,long> dico)
		{
			if (dico.ContainsKey (coin))
				return dico [coin];
			else {
				long n2 = coin / 2;
				long n3 = coin / 3;
				long n4 = coin / 4;
				long conv4 = Conversion (n4, dico);
				long conv2 = Conversion (n2, dico);
				long conv3 = Conversion (n3, dico);

				long maxconvn = dico [n4] + dico [n3] + dico [n2];
				if (maxconvn > coin)
					dico [coin] = maxconvn;
				else
					dico [coin] = coin;
			}
			return dico [coin];
		}
	}
}

