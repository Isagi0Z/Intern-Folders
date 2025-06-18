using System;
using System.Linq;
namespace HelloWorld
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
			Array.Sort(cars);
			foreach(string i in cars)
			{
				Console.WriteLine(i);
			}
			Arrmeth obj1 = new Arrmeth();
			obj1.Displaystats();

			Console.WriteLine("Accessing in Multidimensional arrays \n");
			Multiar obj2 = new Multiar();
			obj2.Accesselem();

			Console.WriteLine("Change elements of a 2d array: \n");
			Multiar obj3 = new Multiar();
			obj3.changeelem();

			Console.WriteLine("Loop through 2d array: \n");
			Multiar obj4 = new Multiar();
			obj4.loopthro();
			
		}
	}
}
