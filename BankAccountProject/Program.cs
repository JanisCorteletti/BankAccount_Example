using System;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Luck";
            var interestRate = 0.5;
            var withdrawValue = 60;
            var depositValue = 50;

            BankAccount bank = new BankAccount(name, 50, interestRate);
            bank.Withdraw(withdrawValue);
            Console.WriteLine(bank.ToString());

            bank.AddInterests();
            Console.WriteLine(bank.ToString());

            //Do not allow withdraw more than the balance - for saving account
            //SavingAccount saving = new SavingAccount(name, 50, interestRate);
            //saving.Withdraw(withdrawValue);
            //Console.WriteLine(saving.ToString());

            CheckAccount check = new CheckAccount(name, 50, interestRate);
            check.Withdraw(withdrawValue);
            Console.WriteLine(check.ToString());

            BankAccount bankDeposit = new BankAccount(name, 50, interestRate);
            bankDeposit.Deposit(depositValue);
            Console.WriteLine(bankDeposit.ToString());

            LotteryAccount lotteryAccount = new LotteryAccount(name, 50);
            Console.WriteLine(lotteryAccount.ToString());

            lotteryAccount.AddInterests();
            Console.WriteLine(lotteryAccount.ToString());


            Console.ReadLine();
        }
    }
}
