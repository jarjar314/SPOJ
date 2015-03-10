using System;

namespace SPOJ
{
	public class FactorialTrailingZeroes
	{
		public FactorialTrailingZeroes ()
		{
			int T = int.Parse(Console.ReadLine());
			for (int i = 0; i < T; i++)
			{
				int nb = int.Parse(Console.ReadLine());
				int zeroes = 0;
				int pow5 = 5; 
				while (nb >=pow5)
				{
					zeroes += (nb / pow5);
					pow5 *= 5;
				}
				Console.WriteLine(zeroes);
			}
		}
	}
}

