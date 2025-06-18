using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.honk();
			Console.WriteLine(myCar.brand + " " + myCar.modelName);

			Animal myAnimal = new Animal();
			Animal myPig = new Pig();
			Animal myDog = new Dog();

			myAnimal.animalsound();
			myPig.animalsound();
			myDog.animalsound();
		}
	}
}