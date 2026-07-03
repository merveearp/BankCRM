using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class CustomerNote: AuditEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AppUserId { get; set; }
        public string NoteText { get; set; } = null!;
        public DateTime? FollowUpDate { get; set; }
      


        public Customer Customer { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;
    }
}
