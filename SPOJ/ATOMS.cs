using System;

namespace SPOJ
{
	public class ATOMS
	{
		public ATOMS ()
		{
			int test = int.Parse (Console.ReadLine ());
			for (int i = 0; i < test; i++) {
				string[] lines = Console.ReadLine ().Split (' ');
				long N = long.Parse (lines [0]);
				long K = long.Parse (lines [1]);
				long M = long.Parse (lines [2]);
				int T = 0;
				while (M / K >= N) {
					T++;
					N = N * K;
				}

				Console.WriteLine (T);
			}
		}
	}
}

