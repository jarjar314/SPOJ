using System;
using System.Collections.Generic;

namespace SPOJ
{
	public class AE1B
	{
		public AE1B ()
		{
			string[] nks = Console.ReadLine ().Split (' ');
			int n = int.Parse (nks [0]); // # of boxes
			int k = int.Parse (nks [1]); // # of screws per table
			int s = int.Parse (nks [2]); // # of tables
			int nbScrews = k * s; // total number of screws
			string[] boxes = Console.ReadLine ().Split (' ');
			List<int> screws = new List<int> ();
			for (int i = 0; i < n; i++) {
				screws.Add (int.Parse (boxes [i]));
			}
			screws.Sort ();
			int output = 0;
			int usedScrews = 0;
			for (int i = n - 1; i >= 0; i--) {
				usedScrews += screws [i];
				output++;
				if (usedScrews >= nbScrews)
					break;
			}
			Console.WriteLine (output);
		}
	}
}

