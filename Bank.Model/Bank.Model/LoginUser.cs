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

            Console.Write("Enter your account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Find the account by account number and password
            Account account = bank.GetAccounts().Find(a => a.AccountNumber == accountNumber && a.Password == password);

            if (account != null)
            {
                Console.WriteLine($"Welcome, {account.OwnerFullName}!");

                int choice;
                do
                {
                    Console.WriteLine("\nMAIN MENU");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Transfer");
                    Console.WriteLine("4. Print Statement");
                    Console.WriteLine("5. Display Balance");
                    Console.WriteLine("6. Set Up Another Account");
                    Console.WriteLine("7. Exit");

                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

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
