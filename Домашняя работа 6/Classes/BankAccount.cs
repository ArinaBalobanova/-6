using System;

namespace HomeWork.Classes
{
    public enum AccountType
    {
        Savings,
        Current,
    }

    class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        public BankAccount()
        {
        }

        public BankAccount(string accountNumber, decimal Balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = Balance;
            this.accountType = accountType;
        }
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}