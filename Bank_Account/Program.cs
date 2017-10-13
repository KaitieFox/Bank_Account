using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice = 0;


            Client user = new Client("Moses Gilford", "mosesgilford", 100001);

            Checking userChecking = new Checking(1000.00);
            Savings userSavings = new Savings(10000.00);

            Console.WriteLine("Figure out what cha wanna do.");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");

            userChoice = int.Parse(Console.ReadLine());
            //run userchoice loop.
            do
            {
                switch (userChoice)
                {
                    case 1:
                        //method for user info
                        break;
                    case 2:
                        Console.WriteLine("View account information for");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        userChoice = int.Parse(Console.ReadLine());
                        if (userChoice == 1)
                        {
                            userChecking.ViewBalance();
                        }
                        else if (userChoice == 2)
                        {
                            userSavings.ViewBalance();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Deposit to");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        userChoice = int.Parse(Console.ReadLine());
                        if (userChoice == 1)
                        {
                            userChecking.Deposit();
                            userChecking.ViewBalance();
                        }
                        else if (userChoice == 2)
                        {
                            userSavings.Deposit();
                            userSavings.ViewBalance();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Withdraw from");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        userChoice = int.Parse(Console.ReadLine());
                        if (userChoice == 1)
                        {
                            userChecking.Withdraw();
                            userChecking.ViewBalance();
                        }
                        else if (userChoice == 2)
                        {
                            userSavings.Withdraw();
                            userSavings.ViewBalance();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You suck");
                        break;
                }


                Console.WriteLine("Need something else?");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");

                userChoice = int.Parse(Console.ReadLine());
            }
            while (userChoice < 5);




        }
    }
}
