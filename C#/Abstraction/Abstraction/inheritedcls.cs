using System;
using AbstractionDemo;

namespace HelloWorld
	{
	class Pig : Animal
	{
		public override void AnimalSound()
		{
			Console.WriteLine("The pig says: wee wee");
			InternalDemo.Message();
		}
	}
}
