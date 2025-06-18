using System;

namespace HelloWorld
{
	abstract class Animal
	{
		public abstract void AnimalSound();

		public void Sleep()
		{
			Console.WriteLine("Zzz");
		}
	}
}