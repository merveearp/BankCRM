using BankCRM.Entity.Entities.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; } 
        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;

        public int BranchId { get; set; }
        public Branch Branch { get; set; } = null!;
        public IList<Customer> Customers { get; set; } = new List<Customer>();
        public IList<CustomerNote> CustomerNotes { get; set; } = new List<CustomerNote>();
        public IList<Activity> Activities { get; set; } = new List<Activity>();
        public IList<CustomerProduct> CustomerProducts { get; set; } = new List<CustomerProduct>();
        public IList<Application> Applications { get; set; } = new List<Application>();
        public IList<Notification> Notifications { get; set; }
           = new List<Notification>();

    }
}
