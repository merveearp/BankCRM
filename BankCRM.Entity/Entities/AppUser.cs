using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class AppUser:BaseEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int BranchId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Phone { get; set; } = null!;
     


        public Role Role { get; set; } = null!;
        public Branch Branch { get; set; } = null!;
        public IList<Customer> Customers { get; set; } 
        public IList<CustomerNote> CustomerNotes { get; set; } 
        public IList<Activity> Activities { get; set; } 
        public IList<CustomerProduct> CustomerProducts { get; set; }
        public IList<Application> Applications { get; set; }

    }
}
