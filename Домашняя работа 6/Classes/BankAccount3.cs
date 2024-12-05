using System;


namespace HomeWork.Classes
{
    class BankAccount3
    {
        private static Random random = new Random();
        private static int accountNumberCounter = 0;
        private string accountNumber;
        private decimal balance;
        private AccType accountType;

        public BankAccount3()
        {
        }

        public BankAccount3(decimal Balance, AccType accountType)
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
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"На счет {accountNumber} внесено {amount}.");
            }
            else
            {
                Console.WriteLine("Сумма должна быть положительной.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Со счета {accountNumber} снято {amount}.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете. Введите меньшую сумму.");
            }
        }
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}