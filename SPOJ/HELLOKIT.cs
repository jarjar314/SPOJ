using System;

namespace SPOJ
{
	public class HELLOKIT
	{
		public HELLOKIT ()
		{
			string line = Console.ReadLine ();
			while (line != ".") {
				string[] lines = line.Split (' ');
				int nb = int.Parse (lines [1]);
				string word = lines [0];
				int length = word.Length;
				string output = String.Empty;
				for (int i = 0; i < nb; i++)
					output += word;
				for (int i = 0; i < length; i++) {
					Console.WriteLine (output);
					output = output.Substring (1) + output [0];
				}
				line = Console.ReadLine ();
			}
		}
	}
}

