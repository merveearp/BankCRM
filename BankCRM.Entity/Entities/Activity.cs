using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AppUserId { get; set; }
        public string ActivityType { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime ActivityDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = null!;


        public Customer Customer { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
    }
}
