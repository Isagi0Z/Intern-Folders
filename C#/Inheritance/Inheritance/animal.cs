using System;

namespace HelloWorld
{
	class Pig : Animal
	{
		public override void animalsound()
		{
			Console.WriteLine("The pig Says: wee wee");
		}
	}
	class Dog : Animal
	{
		public override void animalsound()
		{
			Console.WriteLine("The dog says: bow wow");
		}
	}
}
