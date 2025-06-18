using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Dictionary<string, int> studentMarks = new Dictionary<string, int>();

		// Adding values
		studentMarks["Alice"] = 85;
		studentMarks["Bob"] = 92;
		studentMarks["Charlie"] = 78;

		// Accessing values
		Console.WriteLine("Bob's mark: " + studentMarks["Bob"]);

		// Iterating through dictionary
		foreach(KeyValuePair<string, int> pair in studentMarks)
		{
			Console.WriteLine(pair.Key + " -> " + pair.Value);
		}
	}
}
