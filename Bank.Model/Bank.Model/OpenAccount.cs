using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class OpenAccount
    {
        public static void CreateAccount(this Bank bank)
        {
            Console.WriteLine("CREATE ACCOUNT\n");

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Generate a random account number
            Random random = new Random();
            string accountNumber = random.Next(1000000000, 2000000000).ToString();

            Console.Write("Enter your account type: ");
            string accountType = Console.ReadLine();

            Console.Write("Enter your initial balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            Account account = new Account
            {
                OwnerFullName = fullName,
                AccountNumber = accountNumber,
                AccountType = accountType,
                Balance = balance,
                Password = password
            };

            bank.AddAccount(account);

            Console.WriteLine("Account created successfully!");

            // Display the created account details
            account.PrintAccountDetails();
        }






    }
}
