using System;

namespace SPOJ
{
	public class ABSYS
	{
		public ABSYS ()
		{
			int T = int.Parse (Console.ReadLine ());
			for (int i = 0; i < T; i++) {
				Console.ReadLine (); // each test case is separated by a blank line.
				string[] line = Console.ReadLine ().Split (' ');
				int a = 0, b = 0, c = 0;
				if (line [0].Contains ("machula")) {
					b = int.Parse (line [2]);
					c = int.Parse (line [4]);
					a = c - b;
				} else if (line [2].Contains ("machula")) {
					a = int.Parse (line [0]);
					c = int.Parse (line [4]);
					b = c - a;
				} else if (line [4].Contains ("machula")) {
					a = int.Parse (line [0]);
					b = int.Parse (line [2]);
					c = a + b;
				}
				Console.WriteLine ("{0} + {1} = {2}", a, b, c);
			}
		}
	}
}

