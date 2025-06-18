using System;

namespace Insurance
{
    class Insurancetype
    {
        public void InsuranceType(user s1)
        {
            int n;
            
            Console.WriteLine("1. Life Insurance\n 2. Health Insurance\n 3.Vechicle\n 4.Exit");
            string str = Console.ReadLine();
            n = Convert.ToInt32(str);
            switch (n)
            {
                case 1:
					Lifeinsurance l1= new Lifeinsurance();
                    l1.LifeInsurance(s1);

					break;
                case 2:
					Healthinsurance h1= new Healthinsurance();
                    h1.HealthInsurance(s1);
					break;
                case 3:
                    Console.WriteLine("vechicle method\n");
                    break;
                
            }
        }
    }
}