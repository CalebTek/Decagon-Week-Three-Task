using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{

    public class Program
    {
        public static void Main()
        {
            Bank bank = new Bank();

            int choice;
            do
            {
                DisplayUI.DiplayMenu();

                choice = ConsoleUserInput.GetChoice();

                switch (choice)
                {
                    case 1:
                        bank.CreateAccount();
                        break;
                    case 2:
                        bank.Login();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 3);
        }

    }
}
