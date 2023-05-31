﻿using System;
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

            string fullName = ConsoleUserInput.GetFullName();

            string password = ConsoleUserInput.GetPassword();

            // Generate a random account number
            Random random = new Random();
            string accountNumber = random.Next(1000000000, 2000000000).ToString();

            DisplayUI.AccountType();
            int choice = ConsoleUserInput.GetChoice(2);
            string accountType = "";
            switch(choice)
            {
                case 1:
                    accountType = "Savings";
                    break;
                case 2:
                    accountType = "Current";
                    break;

            }

            decimal balance = ConsoleUserInput.GetAmount("Enter your initial balance: ");

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
