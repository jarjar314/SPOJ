using System;

namespace SPOJ
{
	public class ANARC08E
	{
		public ANARC08E ()
		{
			string line = Console.ReadLine ();
			while (line != "-1 -1") {
				string[] lines = line.Split (' ');
				int a = int.Parse (lines [0]);
				int b = int.Parse (lines [1]);
				if (a == 1 || b == 1)
					Console.WriteLine ("{0}+{1}={2}", a, b, a + b);
				else
					Console.WriteLine ("{0}+{1}!={2}", a, b, a + b);
				line = Console.ReadLine ();
			}
		}
	}
}

