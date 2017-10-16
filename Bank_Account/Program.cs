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

            //hardcoded user info
            Client user = new Client("Moses Gilford", "mosesgilford", 100001);

            Checking userChecking = new Checking(1000.00);
            Savings userSavings = new Savings(10000.00);

            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //run userchoice loop.
            do
            {
                switch (userChoice)
                {
                    case 1: //Client info
                        user.GetInfo();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("View account information for");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");                        
                        userChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (userChoice == 1) //Checking, Accounts base method
                        {
                            userChecking.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 2) //Savings, Accounts base method
                        {
                            userSavings.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("Thank you");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Deposit to");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        userChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (userChoice == 1)
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double userDeposit = double.Parse(Console.ReadLine());
                            userChecking.Deposit(userDeposit); //Checking, Accounts Deposit method
                            userChecking.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double userDeposit = double.Parse(Console.ReadLine());
                            userSavings.Deposit(userDeposit); //Savings, Acounts Deposit method
                            userSavings.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("Thank you");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Withdraw from");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        userChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (userChoice == 1)
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            double userWithdraw = double.Parse(Console.ReadLine());
                            userChecking.Deposit(userWithdraw);  //Checking, Accounts base method
                            userChecking.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            double userWithdraw = double.Parse(Console.ReadLine());
                            userSavings.Withdraw(userWithdraw);  //Savings override, Accounts base method
                            userSavings.ViewBalance();
                            Console.WriteLine();
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("Thank you");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid option.");
                        break;
                }


                Console.WriteLine("Need something else?");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 5)
                {
                    Console.WriteLine("Thank you.");
                }
            }
            while (userChoice < 5);




        }
    }
}
