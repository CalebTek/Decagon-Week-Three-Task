using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class ConsoleUserInput
    {
        public static int GetChoice()
        {
            int choice = 0;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer choice.");
                }
                else if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                }
                else
                {
                    isValidChoice = true;
                }
            }

            return choice;
        }

        public static int GetChoice(int max)
        {
            int choice = 0;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer choice.");
                }
                else if (choice < 1 || choice > max)
                {
                    Console.WriteLine($"Invalid choice. Please enter a number between 1 and {max}.");
                }
                else
                {
                    isValidChoice = true;
                }
            }

            return choice;
        }

        public static string GetAccountNumber()
        {
            string accountNumber = "";

            while (string.IsNullOrEmpty(accountNumber) || accountNumber.Length != 10)
            {
                Console.Write("Enter account number (must be 10 characters): ");
                accountNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(accountNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid account number.");
                }
                else if (accountNumber.Length != 10)
                {
                    Console.WriteLine("Invalid account number length. It must be exactly 10 characters.");
                }
            }

            return accountNumber;
        }

        public static string GetPassword()
        {
            string password = "";

            while (string.IsNullOrEmpty(password) || !IsValidPassword(password))
            {
                Console.Write("Enter your password (must contain at least 8 characters and include both letters and numbers): ");
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Invalid input. Please enter a valid password.");
                }
                else if (!IsValidPassword(password))
                {
                    Console.WriteLine("Invalid password. It must contain at least 8 characters and include both letters and numbers.");
                }
            }

            return password;
        }

        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasLetter = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }

                if (hasLetter && hasNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetFullName()
        {
            string fullName = "";

            while (string.IsNullOrEmpty(fullName) || !IsValidFullName(fullName))
            {
                Console.Write("Enter your full name: ");
                fullName = Console.ReadLine();

                if (string.IsNullOrEmpty(fullName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid full name.");
                }
                else if (!IsValidFullName(fullName))
                {
                    Console.WriteLine("Invalid full name. It must contain at least two words.");
                }
            }

            return fullName;
        }

        public static bool IsValidFullName(string fullName)
        {
            string[] nameParts = fullName.Split(' ');

            return nameParts.Length >= 2;
        }

        public static decimal GetAmount(string prompt)
        {
            decimal number = 0;
            bool isValidNumber = false;

            while (!isValidNumber)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }
                else
                {
                    isValidNumber = true;
                }
            }

            return number;
        }




    }
}
