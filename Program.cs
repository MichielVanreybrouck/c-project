using System;
using Banking.Domain;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("123-456789-99");
            BankAccount ba2 = new BankAccount("000-456789-99", 1000);

            Console.WriteLine($"Acount number is {ba.AccountNumber} - Balance is {ba.Balance}");
            Console.WriteLine($"Acount number is {ba2.AccountNumber} - Balance is {ba2.Balance}");
        }
    }
}
