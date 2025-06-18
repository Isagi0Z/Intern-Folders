using System;

namespace Insurance
{

	class Healthinsurance
	{
		double Coverageamt;
		double fixedamt = 1000;
		double blocks;
		double rateper;
		double amt;
		int y;
		double Yearlyamt;
		int maturityyr;
		int Startyr = 2025;
		public void TermPlan(double amt)
		{
			Console.WriteLine("Choose Term: ");
			Console.WriteLine("1. 1 Years\n 2. 2 Years\n 3. 3 Years");
			string str = Console.ReadLine();
			y = Convert.ToInt32(str);
			switch(y)
			{
				case 1:
					Console.WriteLine("Amount to be paid per year: ");
					Yearlyamt = amt * 1;
					Console.WriteLine("Yearly Payment: " + Yearlyamt);
					maturityyr = Startyr + y;
					Console.WriteLine("Maturity year: " + maturityyr);

					break;
				case 2:
					Console.WriteLine("Amount to be paid per year: ");
					Yearlyamt = amt * 2;
					Console.WriteLine("Yearly Payment: " + Yearlyamt);
					maturityyr = Startyr + y;
					Console.WriteLine("Maturity year: " + maturityyr);
					break ;
				case 3:
					Console.WriteLine("Amount to be paid per year: ");
					Yearlyamt = amt * y;
					Console.WriteLine("Yearly Payment: " + Yearlyamt);
					maturityyr = Startyr + 3;
					Console.WriteLine("Maturity year: " + maturityyr);
					break;
			}
		}
		public void HealthInsurance(user s1)
		{ 

					List<Healthinsurance> User = new List<Healthinsurance>();
					Healthinsurance hi1 = new Healthinsurance();
					Console.WriteLine("Policyholder Name: " + s1.Policyholdername);
					Console.WriteLine("Policyholder Age: " + s1.Age);
					if(s1.Age >= 18 && s1.Age <= 25)
					{
						rateper = 2.0;
						Console.WriteLine("Enter Coverage amount: ");
						hi1.Coverageamt = Convert.ToDouble(Console.ReadLine());
						blocks = hi1.Coverageamt / fixedamt;
						amt = blocks * rateper;
						hi1.TermPlan(amt);
					}
					else if(s1.Age > 25 && s1.Age <= 35)
					{
						rateper = 2.5;
						Console.WriteLine("Enter Coverage amount: ");
						hi1.Coverageamt = Convert.ToDouble(Console.ReadLine());
						blocks = hi1.Coverageamt / fixedamt;
						amt = blocks * rateper;
						hi1.TermPlan(amt);
					}
					else if(s1.Age > 35 && s1.Age <= 45)
					{
						rateper = 3.5;
						Console.WriteLine("Enter Coverage amount: ");
						hi1.Coverageamt = Convert.ToDouble(Console.ReadLine());
						blocks = hi1.Coverageamt / fixedamt;
						amt = blocks * rateper;
						hi1.TermPlan(amt);
					}
					else if(s1.Age > 45 && s1.Age <= 60)
					{
						rateper = 5.0;
						Console.WriteLine("Enter Coverage amount: ");
						hi1.Coverageamt = Convert.ToDouble(Console.ReadLine());
						blocks = hi1.Coverageamt / fixedamt;
						amt = blocks * rateper;
						hi1.TermPlan(amt);
					}
					else if(s1.Age > 60)
					{
						rateper = 7.0;
						Console.WriteLine("Enter Coverage amount: ");
						hi1.Coverageamt = Convert.ToDouble(Console.ReadLine());
						blocks = hi1.Coverageamt / fixedamt;
						amt = blocks * rateper;
						hi1.TermPlan(amt);
					}

				
			}
		
		}
	}

