using System;

namespace Insurance
{
	class Lifeinsurance
	{
		string Nominee;
		int Sumassured;
		int Monthpayment;
		int policyterm;
		int y;
		int Startyr = 2025;
		int maturityyr;
		int totmon;
		public void TermPlan(int Sumassured)
		{
			Console.WriteLine("Choose Term: ");
			Console.WriteLine("1. 10 Years\n 2. 20 Years\n 3.30 Years");
			string str = Console.ReadLine();
			y = Convert.ToInt32(str);
			switch(y)
			{
				case 1:
					maturityyr = Startyr + 10;
					totmon = 10 * 12;
					Monthpayment = Sumassured / totmon;
					Console.WriteLine("Monthly Payment " + Monthpayment);
					Console.WriteLine("Maturity year: " + maturityyr);

					break;
				case 2:
					maturityyr = Startyr + 20;
					totmon = 20 * 12;
					Monthpayment = Sumassured / totmon;
					Console.WriteLine("Monthly Payment " + Monthpayment);
					Console.WriteLine("Maturity year: " + maturityyr);
					break;
				case 3:
					maturityyr = Startyr + 30;
					totmon = 30 * 12;
					Monthpayment = Sumassured / totmon;
					Console.WriteLine("Monthly Payment " + Monthpayment);
					Console.WriteLine("Maturity year: " + maturityyr);
					break;
			}
		}




		public void LifeInsurance(user s1)
		{

			List<Lifeinsurance> User = new List<Lifeinsurance>();
			Lifeinsurance li1 = new Lifeinsurance();
			Console.WriteLine("Policy Holder name: " + s1.Policyholdername);
			Console.WriteLine("Nominee: ");
			li1.Nominee = Console.ReadLine();
			Console.WriteLine("Amount paid to nominee: ");
			li1.Sumassured = Convert.ToInt32(Console.ReadLine());
			li1.TermPlan(li1.Sumassured);
			
		}
	}
}