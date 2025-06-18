using System;
using System.Linq;

namespace HelloWorld
{
	public class Arrmeth
	{
		public void Displaystats()
		{
			int[] mynum = { 56, 23, 77, 23 };
			Console.WriteLine(mynum.Max());
			Console.WriteLine(mynum.Min());
			Console.WriteLine(mynum.Sum());
		}
	}
}
