using System;

namespace SPOJ
{
	public class DIVSUM
	{
		public DIVSUM ()
		{
			int n = int.Parse (Console.ReadLine ());
			for (int i = 0; i < n; i++) {
				int input = int.Parse(Console.ReadLine ());
				if (input == 1) {
					Console.WriteLine (0);
					continue;
				}
				int sumdiv = 1;
				for (int j = 2; j < input; j++) {
					if (j * j > input)
						break;
					if (input % j == 0) {
						sumdiv += j;
						if (j * j != input)
							sumdiv += (input / j);
					}
				}
				Console.WriteLine (sumdiv);
			}
		}
	}
}

