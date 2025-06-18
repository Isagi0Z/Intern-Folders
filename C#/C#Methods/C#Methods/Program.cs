using System;

namespace HelloWorld
{
	class Program
	{
		static int PlusMethod(int x, int y)
		{
			return x + y;
		}
		static double PlusMethod(double x, double y)
		{
			return x * y;
		}
		static void Main(string[] args)
		{
			int num1 = PlusMethod(7, 5);
			double num2 = PlusMethod(7.4, 2.6);
			Console.WriteLine(num1);
			Console.WriteLine(num2);
		}
	}
}