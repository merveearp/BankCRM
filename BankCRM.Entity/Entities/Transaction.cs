using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string TransactionNumber { get; set; } = null!;
        public string TransactionType { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal BalanceAfterTransaction { get; set; }
        public string? Description { get; set; }


        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public Account Account { get; set; } = null!;
    }
}
