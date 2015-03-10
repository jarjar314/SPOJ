using System;

namespace SPOJ
{
	public class AMR10F
	{
		public AMR10F ()
		{
			int testCase = int.Parse (Console.ReadLine ());
			for (int i = 0; i < testCase; i++) {
				string[] nad = Console.ReadLine ().Split (' ');
				int n = int.Parse (nad [0]);
				int a = int.Parse (nad [1]);
				int d = int.Parse (nad [2]);
				Console.WriteLine (n * a + n * (n - 1) / 2 * d);
			}
		}
	}
}

