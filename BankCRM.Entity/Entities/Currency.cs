using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Currency:BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Symbol { get; set; } = null!;
    

        //Navigation
        public IList<Account> Accounts { get; set; } 
    }
}
