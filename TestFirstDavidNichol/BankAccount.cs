using System;
using System.Collections.Generic;
using System.Text;

namespace TestFirstDavidNichol
{
    public class BankAccount
    {
        public enum AccountType { Checking, Savings};
        public AccountType accountType;

        public bool isNegative;

        public double balance;

        public string About()
        {          
            return $"";
        }

        public void Deposit(int amount)
        {
        }

        public void Withdraw(int amount)
        {
        }

        public string TransferFunds(BankAccount otherAccount, double amount)
        {
             return $"";
        }
    }
}
