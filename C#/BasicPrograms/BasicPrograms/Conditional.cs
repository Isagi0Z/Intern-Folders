using System;

namespace HelloWorld
{

	public class Condition
	{
		public void Lesgre(int Num3)
		{
			if(Num3 < 50)
			{
				Console.WriteLine("Fail");
			}
			else
			{
				Console.WriteLine("Pass");
			}
		}
	}

	public class Condition2
	{
		public void Switchcase(int day)
		{
			switch(day)
			{
				case 1:
					Console.WriteLine("Monday");
					break;
				case 2:
					Console.WriteLine("Tuesday");
					break;
				case 3:
					Console.WriteLine("Wednesday");
					break;
				default:
					Console.WriteLine("The end of days");
					break;
			}
		}
	}
}