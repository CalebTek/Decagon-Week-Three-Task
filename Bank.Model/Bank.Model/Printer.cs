using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class Printer
    {
        public static void PrintStatement(this Account account)
        {
            Console.WriteLine($"ACCOUNT STATEMENT ON ACCOUNT NO {account.AccountNumber}\n");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
            Console.WriteLine("| DATE              | DESCRIPTION                   | AMOUNT                   | BALANCE             |");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");

            foreach (Transaction transaction in account.Transactions)
            {
                Console.WriteLine($"| {transaction.Date} | {transaction.Description} | {transaction.Amount} | {transaction.Balance} |");
            }

            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        }

        public static void DisplayBalance(this Account account)
        {
            Console.WriteLine($"ACCOUNT DETAILS\n");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
            Console.WriteLine("| FULL NAME         | ACCOUNT NUMBER                | ACCOUNT TYPE             | AMOUNT BAL          |");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
            Console.WriteLine($"| {account.OwnerFullName,-18} | {account.AccountNumber,-30} | {account.AccountType,-24} | {account.Balance,-19} |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        }

        public static void PrintAccountDetails(this Account account)
        {
            Console.WriteLine($"ACCOUNT DETAILS\n");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
            Console.WriteLine("| FULL NAME         | ACCOUNT NUMBER                | ACCOUNT TYPE             | AMOUNT BAL          |");
            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
            Console.WriteLine($"| {account.OwnerFullName,-18} | {account.AccountNumber,-30} | {account.AccountType,-24} | {account.Balance,-19} |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        }

    }
}
