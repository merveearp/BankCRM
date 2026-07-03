using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Branch:BaseEntity
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; } 
        public string City { get; set; } 
        public string Phone { get; set; } 
 

        public IList<AppUser> AppUsers { get; set; } 
        public IList<Customer> Customers { get; set; }
    }
}
