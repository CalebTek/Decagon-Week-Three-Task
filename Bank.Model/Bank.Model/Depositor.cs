using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class Depositor
    {
        public static void Deposit(this Account account)
        {
            Console.WriteLine("DEPOSIT\n");

            Console.Write("Enter the deposit amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            account.Balance += amount;

            // Add the deposit transaction to the account's transaction history
            account.Transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = "Deposit",
                Amount = amount,
                Balance = account.Balance
            });

            Console.WriteLine("Deposit successful!");
        }

    }
}
