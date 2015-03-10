using System;

namespace SPOJ
{
	public class ACPC10A
	{
		public ACPC10A ()
		{
			string line = Console.ReadLine ();
			while (line != "0 0 0") {
				string[] lines = line.Split (' ');
				int a = int.Parse (lines [0]);
				int b = int.Parse (lines [1]);
				int c = int.Parse (lines [2]);
				if (b - a == c - b) {
					Console.WriteLine ("AP {0}", 2 * c - b);
				} else {
					Console.WriteLine ("GP {0}", c * c / b);
				}
				line = Console.ReadLine ();
			}
		}
	}
}

