using System;
using System.Collections.Generic;

namespace SPOJ
{
	public class TSORT
	{
		// TOO LONG
		public TSORT ()
		{
			List<int> list = new List<int> ();
			int t = int.Parse (Console.ReadLine ());
			for (int i = 0; i < t; i++) {
				list.Add (int.Parse (Console.ReadLine ()));
			}
			list.Sort ();
			foreach (var n in list) {
				Console.WriteLine (n);
			}
		}
	}
}

