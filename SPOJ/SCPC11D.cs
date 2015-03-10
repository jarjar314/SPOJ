using System;

namespace SPOJ
{
	public class SCPC11D
	{
		public SCPC11D ()
		{
			string line = Console.ReadLine ();
			while (line != "0 0 0") {
				string[] lines = line.Split (' ');
				int a = int.Parse (lines [0]);
				int b = int.Parse (lines [1]);
				int c = int.Parse (lines [2]);
				int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
				int min = a < b ? (a < c ? a : c) : (b < c ? b : c);
				int mid = a + b + c - min - max;
				if (min * min + mid * mid - max * max == 0)
					Console.WriteLine ("right");
				else
					Console.WriteLine ("wrong");
				line = Console.ReadLine ();
			}
		}
	}
}

