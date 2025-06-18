using System;

namespace Insurance
{

	public class Class1
	{
		public void adduser()
		{
			int n;

			Console.WriteLine("1. Add user\n 2. Exit\n ");
			string str = Console.ReadLine();
			n = Convert.ToInt32(str);
			switch(n)
			{
				case 1: 
					Class1 class1 = new Class1();
					class1.Adduser();
					break;
                case 2:
					Console.WriteLine("Exiting...");
					return;
			}
		}
            
		public void Adduser()
		{
			user s1 = new user();
			s1.NewUser();

		}
	}
}
