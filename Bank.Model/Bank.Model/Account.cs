using System.Collections.Generic;

namespace Bank.Model
{
    public class Account
    {
        public string OwnerFullName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string Password { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Account()
        {
            Transactions = new List<Transaction>();
        }
    }
}
