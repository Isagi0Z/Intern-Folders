using System;

namespace HelloWorld
{
	class Program
	{
		private string model = "Mustang";
		static void Main(string[] args)
		{
			Program obj1 = new Program();
			Console.WriteLine(obj1.model);
			Car obj2 = new Car();
			Console.WriteLine(obj2.model);
		}
	}
}