using System;
using System.Collections.Generic;

namespace SPOJ
{
	public class MIRRORED
	{
		public MIRRORED ()
		{
			Console.WriteLine ("Ready");
			string line = Console.ReadLine ();
			List<string> entry = new List<string> () {"db","bd","pq","qp"};
			while (line != "  ") {
				if (entry.Contains (line))
					Console.WriteLine ("Mirrored pair");
				else
					Console.WriteLine ("Ordinary pair");
				line = Console.ReadLine ();
			}
		}
	}
}

