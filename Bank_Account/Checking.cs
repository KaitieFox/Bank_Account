using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Accounts
    {
        

        //constructor
        public Checking()
        {

        }

        public Checking(double accountBalance)
        {
            this.accountType = "checking";
            this.accountBalance = accountBalance;
        }




        //methods
        public override void ViewBalance()
        {
            Console.WriteLine("Your checking balance is: $" + accountBalance); //this is a maybe. Return here if problems arise.
        }

        public override double Deposit() //so, this should be simplified? Doesn't work if I call upon the base method without writing it all.
        {
            Console.WriteLine("How much would you like to deposit?");
            double userDeposit = double.Parse(Console.ReadLine());
            accountBalance += userDeposit;
            return accountBalance;
        }

        public override double Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double userWithdraw = double.Parse(Console.ReadLine());
            accountBalance -= userWithdraw;
            return accountBalance;

        }


    }
}
