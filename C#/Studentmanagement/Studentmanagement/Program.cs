using System;
using System.Collections.Generic;

namespace StudentApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create students using both constructors
			Student s1 = new Student(); // default
			Student s2 = new Student("Asha", 101, "Computer Science"); // parameterized

			// Use a List to store the students
			List<Student> students = new List<Student>() { s1, s2 };

			// Display information of each student
			foreach(Student s in students)
			{
				s.DisplayInfo();
			}
		}
	}

	class Student
	{
		public string Name;
		public int Rollno;
		public string Department; // corrected spelling

		// Default constructor
		public Student()
		{
			Name = "Not Assigned";
			Rollno = 0;
			Department = "Undeclared"; // added missing semicolon
		}

		// Parameterized constructor
		public Student(string name, int rollno, string dept)
		{
			Name = name;
			Rollno = rollno;
			Department = dept;
		}

		public void DisplayInfo()
		{
			// Proper string formatting
			Console.WriteLine($"Name: {Name}, Roll No: {Rollno}, Department: {Department}");
		}
	}
}
