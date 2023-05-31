using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class Withdrawal
    {
        public static void Withdraw(this Account account)
        {
            Console.WriteLine("WITHDRAW\n");

            Console.Write("Enter the withdrawal amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > account.Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                account.Balance -= amount;

                // Add the withdrawal transaction to the account's transaction history
                account.Transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Description = "Withdrawal",
                    Amount = amount,
                    Balance = account.Balance
                });

                Console.WriteLine("Withdrawal successful!");
            }
        }

    }
}
