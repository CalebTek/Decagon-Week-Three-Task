using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class LoginUser
    {
        public static void Login(this Bank bank)
        {
            Console.WriteLine("LOGIN\n");

            //Console.Write("Enter your account number: ");
            //string accountNumber = Console.ReadLine();
            string accountNumber = ConsoleUserInput.GetAccountNumber();

            //Console.Write("Enter your password: ");
            //string password = Console.ReadLine();
            string password = ConsoleUserInput.GetPassword();

            // Find the account by account number and password
            Account account = bank.GetAccounts().Find(a => a.AccountNumber == accountNumber && a.Password == password);

            if (account != null)
            {
                Console.WriteLine($"Welcome, {account.OwnerFullName}!");

                int choice;
                do
                {
                    DisplayUI.DiplayUserMenu();

                    choice = ConsoleUserInput.GetChoice(7);

                    switch (choice)
                    {
                        case 1:
                            account.Deposit();
                            break;
                        case 2:
                            account.Withdraw();
                            break;
                        case 3:
                            account.Transfer(bank);
                            break;
                        case 4:
                            account.PrintStatement();
                            break;
                        case 5:
                            account.DisplayBalance();
                            break;
                        case 6:
                            bank.CreateAccount();
                            break;
                        case 7:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();
                } while (choice != 7);
            }
            else
            {
                Console.WriteLine("Invalid account number or password. Please try again.");
            }
        }

    }
}
