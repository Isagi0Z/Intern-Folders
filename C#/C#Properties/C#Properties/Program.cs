using System;

namespace HelloWorld
{
	class person1
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}

	

	class Program
	{
		static void Main(string[] args)
		{
			person1 myobj = new person1();
			myobj.Name = "Liam";
			Console.WriteLine(myobj.Name);

		}
	}
}