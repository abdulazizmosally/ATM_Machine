using System;

namespace ATM_Machine2
{
    class Program
    {
        private static object of;

        public static void drow(ref int blance, ref int number_draw)
        {
            if (number_draw <= blance)
            {
                if (number_draw > 0)
                {
                    if (number_draw % 500 == 0)
                    {
                        blance = blance - number_draw;
                        Console.WriteLine("The Balance :" + blance);
                    }
                    else
                        Console.WriteLine("Invalid Amount ( Not a multiple of 500 )");
                }
                else
                    Console.WriteLine("Invalid Amount ( The Amount should not be 0 or negative )");
            }
            else
                Console.WriteLine(" You don't have enough balance ");
        }
        public static void DepositCash(ref int depositcash, ref int cash)
        {
            depositcash = depositcash + cash;
            Console.WriteLine("The Balance : " + depositcash);
        }
        public static void Check(ref int x)
        {
            Console.WriteLine("Your Balance is :" + x);
        }

        static void Main(string[] args)
        {
            string name = "admin";
            string Password = "1234";
            int Balance = 20000;
            Console.WriteLine("Enter User Name :");
            String User = Console.ReadLine();
            while (User != name)
            {
                Console.Clear();
                Console.WriteLine("User Name is wrong Try Again :");
                Console.WriteLine("Enter User Name :");
                User = Console.ReadLine();
               
            }
            Console.WriteLine("Enter Password :");
            String pass = Console.ReadLine();
            while (pass != Password)
            {
                Console.Clear();
                Console.WriteLine("PIN is wrong Try Agin :");
                Console.WriteLine("Enter Password :");
                pass = (Console.ReadLine());
            }
            if (User == name && pass == Password)
            {
                Console.Clear();
                Console.WriteLine("********* Welcoome To ATM Service *********\n");
            }
            for (int i = 0; i < 1; i--)
            {
                if (i < 0)
                {
                    Console.WriteLine("********* Do you want another service *********\n");
                }
                Console.WriteLine("1.Check Blance \n2.Withdraw Cash \n3.DepositCash \n4.Quit");
                int choece = Convert.ToInt32(Console.ReadLine());
                switch (choece)
                {
                    case 1:
                        {
                            Check(ref Balance); Console.WriteLine(" Enter any key to contenue ....");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" How much do you want to withdraw ?");
                            int draw = Convert.ToInt32(Console.ReadLine());
                            drow(ref Balance, ref draw); Console.WriteLine("\n Enter any key to contenue ....");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("How much money you want to deposit ?");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            DepositCash(ref Balance, ref deposit);
                            Console.WriteLine("\n Enter any key to contenue ....");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(" * Thank you for using the ATM Machine *");
                            i = 100; Console.WriteLine("\n Enter any key to Exit ....");
                            break;
                            
                    }
                    default:
                        {
                            Console.WriteLine(" * Invalid choice please try again *");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
