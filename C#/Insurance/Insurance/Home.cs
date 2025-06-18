using System;

namespace Insurance
{
    class Home
    {
        public void home()
        {
            int n;
            Console.WriteLine("Enter the no to select\n\n");
            
            Console.WriteLine("1. New User\n 2. User Login\n 3.Admin Login\n 4.Exit");
            string str = Console.ReadLine();
            n = Convert.ToInt32(str);
            switch (n)
            {
                    case 1: 
                    user new1 = new user();
                    user registereduser = new1.NewUser();
                    
                    break;
                    case 2: Console.WriteLine("user login");
                    break;
                    case 3: Console.WriteLine("Admin Login\n");
                    break;
                    default: Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
