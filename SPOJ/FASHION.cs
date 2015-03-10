using System;
using System.Collections.Generic;
namespace SPOJ
{
	public class FASHION
	{
		public FASHION ()
		{
			int t = Int32.Parse (Console.ReadLine ());
			for (int i = 0; i < t; i++) {
				int N = Int32.Parse (Console.ReadLine ());
				string[] male = Console.ReadLine ().Split (' ');
				string[] female = Console.ReadLine ().Split (' ');
				List<int> males = new  List<int> ();
				List<int> females = new List<int> ();
				for (int j = 0; j < N; j++) {
					males.Add (int.Parse (male [j]));
					females.Add (int.Parse (female [j]));
				}
				males.Sort ();
				females.Sort ();
				int hotness = 0;
				for (int j = 0; j < N; j++)
					hotness += (males [j] * females [j]);
				Console.WriteLine (hotness);
			}
		}
	}
}

