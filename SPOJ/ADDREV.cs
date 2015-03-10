using System;

namespace SPOJ
{
	public class ADDREV
	{
		public ADDREV ()
		{
			int N = int.Parse (Console.ReadLine ());
			for (int i = 0; i < N; i++) {
				string[] line = Console.ReadLine ().Split (' ');
				string a = line [0];
				string b = line [1];

				string aRev = reverse (a);
				string bRev = reverse (b);
				int ai = int.Parse (aRev);
				int bi = int.Parse (bRev);
				int res = ai + bi;
				Console.WriteLine (int.Parse(reverse (res.ToString ())));
			}
		}

		private string reverse(string a)
		{
			char[] arr = a.ToCharArray ();
			Array.Reverse (arr);
			return new string (arr);
		}

	}
}

