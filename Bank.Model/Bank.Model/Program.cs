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
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

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
