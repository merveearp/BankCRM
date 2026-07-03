using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class CustomerProduct: AuditEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int AppUserId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
     



        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
    }
}
