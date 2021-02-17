using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject
{
    public class LotteryAccount : BankAccount
    {
        private static Lottery lottery = Lottery.Instance(10); //Difficulty level

        public LotteryAccount(string owner, decimal balance) :
          base(owner, balance, 0.0)
        {
        }

        public override void AddInterests()
        {
            int luckyNumber = lottery.DrawLotteryNumber;
            balance = balance + lottery.AmountWon(luckyNumber);
        }

        public override string ToString()
        {
            return owner + "'s lottery account holds " +
                  + balance + " EUR";
        }
    }
}
