using System;
namespace StudentApp
{
	class student
	{
		public string Name;
		public int Rollno;
		public string Department;
		public student()
		{
			Name = "Not Assigned";
			Rollno = 0;
			Department = "Undeclared";
		}
		public student(string name,int rollno,string dept)
		{
			Name = name;
			Rollno = rollno;
			Department = dept;
		}
		public void DisplayInfo()
		{
			Console.WriteLine(Name,Rollno,Department)
		}
	}
}