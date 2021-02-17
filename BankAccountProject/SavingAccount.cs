using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject
{
    public class SavingAccount : BankAccount
    {
        public SavingAccount(string owner, double interestsRate) :
          base(owner, 0.0M, interestsRate)
        {
        }

        public SavingAccount(string owner, decimal balance, double interestsRate) :
          base(owner, balance, interestsRate)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount < balance)
                balance -= amount;
            else
                throw new Exception("Cannot withdraw");
        }

        public override void AddInterests()
        {
            balance = balance + balance * (decimal)interestRate
                              - 100.0M;
        }

        public override string ToString()
        {
            return owner + "'s savings account holds " +
                  + balance + " EUR";
        }
    }
}
