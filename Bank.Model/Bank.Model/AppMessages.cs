using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public static class AppMessages
    {
        public readonly static string startMessage = $"\nMAIN MENU\n1. Create Account\n2. Login\n3. Exit";
        public readonly static string userMessage = $"\nUSER MENU\n1. Deposit\n2. Withdraw\n" +
            $"3. Transfer\n4. Print Statement\n5. Display Balance\n6. Set Up Another Account\n" +
            $"7. Exit";
        public readonly static string AccountMessage = $"\n1. Savings\n2. Current";
    }
}
