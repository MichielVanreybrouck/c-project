using System;
namespace Banking.Domain
{
    public class BankAccount
    {
        #region fields and properties

        private decimal _balance;

        public decimal Balance {
            get {
                return _balance;
            }
            private set {
                if (value < 0)
                    throw new ArgumentException("Balance can not be negative");
                _balance = value;
            }
        }

        public string AccountNumber { get; } = "123-456789-99";




        public BankAccount(string acountNumber,  decimal  intitialBalance = 0)
        {
            AccountNumber = acountNumber;
            Balance = intitialBalance;
            //Cost = 3;
            //costReadOnly = 3;
        }

        #region

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            else
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            else
            {
                Balance -= amount;
            }
        }



   
    }
}
