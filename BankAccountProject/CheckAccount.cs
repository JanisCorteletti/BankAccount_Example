using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject
{
    public class CheckAccount : BankAccount
    {
        public CheckAccount(string owner, double interestsRate) :
          base(owner, 0.0M, interestsRate)
        {
        }

        public CheckAccount(string owner, decimal balance, double interestsRate) :
          base(owner, balance, interestsRate)
        {
        }

        public override void Withdraw(decimal amount)
        {
            balance -= amount;
            if (amount < balance)
                interestRate = -0.10;
        }

        public override string ToString()
        {
            return owner + "'s check account holds " +
                  + balance + " EUR";
        }
    }
}
