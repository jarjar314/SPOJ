using System;

namespace SPOJ
{
	public class LifetheUniverseandEverything
	{
		public LifetheUniverseandEverything ()
		{
			while (true) 
			{ 
				string str = Console.ReadLine(); 
				if (str == "42") 
					break; 
				else 
					Console.WriteLine(str); 
			}
		}
	}
}

