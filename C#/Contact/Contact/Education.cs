using System;

namespace HelloWorld
{
	public class Education
	{
	 	public void Add()
		{
			int mark1, mark2, mark3, mark4;
			Console.WriteLine("Enter your marks: ");

			Console.WriteLine("Enter mark 1: ");
			string strMark1 = Console.ReadLine();
			mark1 = Convert.ToInt32(strMark1);

			Console.WriteLine("Enter mark 2");
			string strMark2 = Console.ReadLine();
			mark2 = Convert.ToInt32(strMark2);

			Console.WriteLine("Enter mark 3");
			string strMark3 = Console.ReadLine();
			mark3 = Convert.ToInt32(strMark3);

			Console.WriteLine("Enter mark 4");
			string strMark4 = Console.ReadLine();
			mark4 = Convert.ToInt32(strMark4);

			int total=mark1+ mark2 + mark3 + mark4;
			Console.WriteLine(total);
		}
	}
}