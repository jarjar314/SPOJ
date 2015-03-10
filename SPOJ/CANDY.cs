using System;
using System.Collections.Generic;

namespace SPOJ
{
	public class CANDY
	{
		public CANDY ()
		{
			string sNbPacket = Console.ReadLine ();
			while (sNbPacket != "-1") {
				int nbPacket = int.Parse (sNbPacket);
				List<int> candies = new List<int> ();
				int totalCandies = 0;
				for (int i = 0; i < nbPacket; i++) {
					int nbCandies = int.Parse (Console.ReadLine ());
					candies.Add (nbCandies);
					totalCandies += nbCandies;
				}
				if (totalCandies % nbPacket != 0) {
					Console.WriteLine ("-1");
					sNbPacket = Console.ReadLine ();
					continue;
				}
				int averageCandies = totalCandies / nbPacket;
				int totalMoves = 0;
				foreach (var i in candies) {
					if (i < averageCandies)
						totalMoves += (averageCandies - i);
				}
				Console.WriteLine (totalMoves);
				sNbPacket = Console.ReadLine ();
			}
		}
	}
}

