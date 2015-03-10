using System;

namespace SPOJ
{
	public class INTEST
	{
		public INTEST ()
		{
			string[] line = Console.ReadLine ().Split(' ');
			int n = int.Parse (line [0]);
			int k = int.Parse (line [1]);
			int count = 0;
			for (int i = 0; i < n; i++) {
				int t = int.Parse(Console.ReadLine ());
				if (t % k == 0)
					count++;
			}
			Console.WriteLine (count);
		}
	}
}

