using System;

namespace SPOJ
{
	public class GNY07A
	{
		public GNY07A ()
		{
			int nb = int.Parse(Console.ReadLine ());
			for (int i = 0; i < nb; i++) {
				string[] input = Console.ReadLine ().Split (' ');
				int index = int.Parse (input [0]);
				string spell = input [1];
				string output = spell.Substring (0, index - 1) + spell.Substring (index);
				Console.WriteLine ("{0} {1}", i + 1, output);
			}
		}
	}
}

