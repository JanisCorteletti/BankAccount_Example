using System;
namespace BankAccountProject
{

    public class BankAccount
    {
        protected string owner;
        protected decimal balance;
        protected double interestRate;

        public BankAccount(string owner, decimal balance, double interestsRate)
        {
            this.owner = owner;
            this.balance = balance;
            this.interestRate = interestsRate;
        }

        public BankAccount(string owner, double interestsRate) :
          this(owner, 0.0M, interestsRate)
        {
        }

        public virtual decimal Balance
        {
            get { return balance; }
        }

        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void AddInterests()
        {
            balance += balance * (Decimal)interestRate;
        }

        public override string ToString()
        {
            return owner + "'s account holds " +
                  + balance + " EUR";
        }
    }
}
