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
        private double minimum = 100.00;

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
            Console.WriteLine("Your savings balance is $" + accountBalance);
        }
                

        public override double Withdraw(double userWithdraw)
        {                        
            if ((accountBalance - userWithdraw) < minimum)
            {
                Console.WriteLine("Insufficient funds to complete withdraw.");
                return accountBalance;             
            }
            else
            {
                base.Withdraw(userWithdraw);
                return accountBalance;
            }
        }

    }
}
