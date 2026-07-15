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
     


        public AppRole AppRole { get; set; } = null!;
        public Branch Branch { get; set; } = null!;
        public IList<Customer> Customers { get; set; } = new List<Customer>();
        public IList<CustomerNote> CustomerNotes { get; set; } = new List<CustomerNote>();
        public IList<Activity> Activities { get; set; } = new List<Activity>();
        public IList<CustomerProduct> CustomerProducts { get; set; } = new List<CustomerProduct>();
        public IList<Application> Applications { get; set; } = new List<Application>();

    }
}
