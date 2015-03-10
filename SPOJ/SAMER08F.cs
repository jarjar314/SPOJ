using System;

namespace SPOJ
{
	public class SAMER08F
	{
		public SAMER08F ()
		{
			string line = Console.ReadLine ();
			while (line != "0") {
				int n = int.Parse (line);
				Console.WriteLine (n * (n + 1) * (2 * n + 1) / 6);
				line = Console.ReadLine ();
			}
		}
	}
}

