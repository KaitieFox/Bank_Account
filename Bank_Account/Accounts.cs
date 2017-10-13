using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Accounts
    {
        //fields
        protected int accountNumber;
        protected double accountBalance;
        protected string accountType;







        //methods
        public abstract void ViewBalance();

        public virtual double Deposit() //I don't think these need to be in existence.
        {
            Console.WriteLine("How much would you like to deposit?");
            double userDeposit = double.Parse(Console.ReadLine());
            return userDeposit;
        }

        public virtual double Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double userWithdraw = double.Parse(Console.ReadLine());
            return userWithdraw;
        }



    }
}
