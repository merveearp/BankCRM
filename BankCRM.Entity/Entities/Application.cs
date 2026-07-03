using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Application:AuditEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AppUserId { get; set; }
        public string ApplicationNumber { get; set; } = null!;
        public string ApplicationType { get; set; } = null!;
        public decimal RequestedAmount { get; set; }
        public int? MaturityMonth { get; set; }
        public decimal MonthlyIncome { get; set; }
        public int CreditScore { get; set; }
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
       



        public Customer Customer { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
    }
}
