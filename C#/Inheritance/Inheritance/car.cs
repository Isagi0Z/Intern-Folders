using System;

namespace HelloWorld
{
	class Vehicle
	{
		public string brand = "Ford";
		public void honk()
		{
			Console.WriteLine("tuut,tuut!");
		}
	}

	class Car : Vehicle
	{
		public string modelName = "Mustang";
	}

}