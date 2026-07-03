using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Account:BaseEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountTypeId { get; set; }
        public int CurrencyId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string Iban { get; set; } = null!;
        public decimal Balance { get; set; }
      


        public Customer Customer { get; set; } = null!;
        public AccountType AccountType { get; set; } = null!;
        public Currency Currency { get; set; } = null!;
        public IList<Transaction> Transactions { get; set; } 

    }
}
