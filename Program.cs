using System;

namespace ConsoleApp12
{
    class BankAccount
    {

        private (int, bool, str) balance;

        public void Deposit(int amount)
        {
            balance += amount;

        }

        public void Withdraw(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }



        public int GetBal()
        {
            return balance;
        }


        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.Deposit(500);
            bankAccount.Withdraw(200);
            Console.WriteLine($"Balance: {bankAccount.GetBal()}");
        }
    }
}
