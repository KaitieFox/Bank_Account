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

        public virtual double Deposit(double userDeposit) 
        {
            accountBalance += userDeposit;
            return accountBalance;
        }

        public virtual double Withdraw(double userWithdraw)
        {
            accountBalance -= userWithdraw;            
            return accountBalance;
        }
        
    }
}
