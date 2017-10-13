using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings : Accounts
    {
        //field
        private double minimum = 0.00;

        //property
        public double Minimum
        {
            get { return this.minimum; }
        }

        //Constructor
        public Savings()
        {

        }

        public Savings(double accountBalance)
        {
            this.accountType = "savings";
            this.accountBalance = accountBalance;
        }

        //methods
        public override void ViewBalance()
        {
            Console.WriteLine("You savings balance is $" + accountBalance);
        }

        public override double Deposit()
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
            accountBalance += userWithdraw;
            return accountBalance;
        }

    }
}
