using System;
using System.Diagnostics;

namespace HelloWorld
{

	class Program
	{
		static void Main(string[] args) {
			string firstName = "John";
			string lastName = "Doe";
			string name = $"My full name is: {firstName} {lastName}";
			Console.WriteLine(name);

			Console.WriteLine("Enter the first no: ");
			int Num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the Second no: ");
			int Num2 = Convert.ToInt32(Console.ReadLine());

			Arithmetic obj1 = new Arithmetic();
			obj1.Add(Num1,Num2);

			Console.WriteLine("Enter the mark to see fail or pass");
			int Num3= Convert.ToInt32(Console.ReadLine());
			Condition obj2 = new Condition();
			obj2.Lesgre(Num3);

			Console.WriteLine("Enter a day: ");
			int day= Convert.ToInt32(Console.ReadLine());
			Condition2 obj3 = new Condition2();
			obj3.Switchcase(day);

			string[] fruits = { "apple", "banana", "guava" };
			foreach (string fruit in fruits)
			{
				Console.WriteLine(fruit);
			}

			int[] numbers = { 1, 2, 3, 4, 5 };
			int sum = 0;

			foreach(int num in numbers)
			{
				sum = sum + num;
			}
			Console.WriteLine(sum);
		}
	}
}