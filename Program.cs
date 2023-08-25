using System;

namespace ConsoleApp12
{
    class BankAccount
    {

        private int balance;

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

        public class Account
        {
            private int balance;
            private bool depositSuccess;
            private string depositMessage;

            public Account()
            {
                balance = 0;
                depositSuccess = false;
                depositMessage = string.Empty;
            }

            public void Deposit(int amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    depositSuccess = true;
                    depositMessage = "Deposit successful";
                }
                else
                {
                    depositSuccess = false;
                    depositMessage = "Deposit amount must be positive";
                }
            }

            //public (int Balance, bool DepositSuccess, string DepositMessage) GetBalanceAndDepositStatus()
            //{
            //    return (balance, depositSuccess, depositMessage);
            //}

            public (string DepositMessage, int Balance, bool DepositSuccess) GetBalanceDeposit()
            {
                return (balance, depositMessage, depositSuccess);
            }
        }

    }
}
