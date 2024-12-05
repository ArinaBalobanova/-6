using System;


namespace HomeWork.Classes
{
    public enum AccType
    {
        Savings,
        Current,
    }
    class BankAccount2
    {
        private static Random random = new Random();
        private static int accountNumberCounter = 0;
        private string accountNumber;
        private decimal balance;
        private AccType accountType;

        public BankAccount2()
        {
        }

        public BankAccount2(decimal Balance, AccType accountType)
        {
            this.accountNumber = UnicAccountNumber();
            this.balance = Balance;
            this.accountType = accountType;
        }
        private string UnicAccountNumber()
        {
            int randomPart = random.Next(1000, 1000000);
            accountNumberCounter++;
            return $"AC{randomPart}-{accountNumberCounter:0000}";
        }
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}
