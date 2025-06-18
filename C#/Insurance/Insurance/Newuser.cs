using System;

namespace Insurance
{


    public class user
    {
        public string Policyholdername;

        public long Age;
        long Contact;
        string Email;

        public user NewUser()
        {
            List<user> User = new List<user>();
            user s1 = new user();
            Console.WriteLine("Enter Policyholder Name: ");
            s1.Policyholdername = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            s1.Age = Convert.ToInt64(Console.ReadLine());
            if(s1.Age > 23)
            {
                Console.WriteLine("You are eligible for insurance");
                Console.WriteLine("Enter Contact: ");
                s1.Contact = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter email: ");
                s1.Email = Console.ReadLine();
                Console.WriteLine("Choose Insurance type: ");

                Insurancetype insurancetype = new Insurancetype();
                insurancetype.InsuranceType(s1);
				Class1 t1 = new Class1();
                t1.adduser();
				return s1;
            }
            else
            {
                Console.WriteLine("you are not eligible for insurance");
                s1.NewUser();
				
			}
            
            return null;
        }
        
    }
}       
    

