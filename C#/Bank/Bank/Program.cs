using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tUser Bank Account Details\n\n ");
			//Console.WriteLine("Enter the no of Users");
			//int nUser = Convert.ToInt32(Console.ReadLine());
			//string[] Name = new string[nUser];
			//string[] Bankname = new string[nUser];
			//int[] Accntno = new int[nUser];
			//for(int i = 0; i < nUser; i++)
			//{
			int balance = 0;
			Console.WriteLine("Enter User Name: ");
			string Name = Console.ReadLine();
			Console.WriteLine("Enter Account no: ");
			int Accntno = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Bank name: ");
			string Bankname = Console.ReadLine();
			int depo, withdraw;
			Console.WriteLine("Enter the amount to be deposited:  ");
			depo = Convert.ToInt32(Console.ReadLine());
			balance = balance + depo;
			Console.WriteLine("Enter the amount to get withdraw: ");
			withdraw = Convert.ToInt32(Console.ReadLine());

			balance = balance - withdraw;
			if(balance >=0) { 
			Console.WriteLine("The final balance amount is: ");
			Console.WriteLine(balance);
		}
			else if(balance < 0) 
			{
					Console.WriteLine("Cannot withdraw that much amt");
			}
			}

		}
	}
