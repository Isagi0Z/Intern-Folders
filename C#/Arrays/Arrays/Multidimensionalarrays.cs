using System;

namespace HelloWorld
{
	public class Multiar
	{
		public void Accesselem()
		{
			int[,] numbers = { { 1, 6, 5 }, { 5, 3, 7 } };
			Console.WriteLine(numbers[1, 2]);
		}
		public void changeelem()
		{
			int[,] numbers = { { 1, 4, 7 }, { 3, 9, 8 } };
			numbers[0, 1] = 22;
			Console.WriteLine(numbers[0, 1]);
		}
		public void loopthro() {
			int[,] numbers = { { 1, 6, 5 }, { 1, 3, 7 } };
			foreach (int i in numbers) {
				Console.WriteLine(i);
			}
		}
	}
}