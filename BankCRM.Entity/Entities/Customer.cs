using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Customer:BaseEntity
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int AppUserId { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string CustomerType { get; set; } = null!;
        public string Segment { get; set; } = null!;
        public int RiskScore { get; set; }
  


        public Branch Branch { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
        public IList<Account> Accounts { get; set; } 
        public IList<CustomerNote> CustomerNotes { get; set; } 
        public IList<Activity> Activities { get; set; } 
        public IList<Application> Applications { get; set; } 
        public IList<CustomerProduct> CustomerProducts { get; set; }
    }
}
