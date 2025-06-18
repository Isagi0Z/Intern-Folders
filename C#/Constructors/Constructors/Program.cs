using System;

namespace HelloWorld
{

	public class Program
	{
		static void Main(string[] args)
		{
			Car1 ford = new Car1();
			Console.WriteLine(ford.model);
			Car2 opera = new Car2("Mustang","white",1996);
			Console.WriteLine(opera.year);
		}
	}
}