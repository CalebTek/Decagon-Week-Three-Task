using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class DisplayUI
    {
        public static void DiplayMenu()
        {
            Console.WriteLine(AppMessages.startMessage);
        }

        public static void DiplayUserMenu() 
        {
            Console.WriteLine(AppMessages.userMessage);
        }

        public static void AccountType()
        {
            Console.WriteLine(AppMessages.AccountMessage);
        }
    }
}
