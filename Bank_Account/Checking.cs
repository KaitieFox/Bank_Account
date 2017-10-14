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
              
    }
}
