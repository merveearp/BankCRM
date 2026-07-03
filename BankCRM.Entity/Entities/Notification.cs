using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int AppUserId { get; set; }
        public string Title { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool IsRead { get; set; } = false;
        public DateTime NotificationDate { get; set; } = DateTime.Now;



        // Navigation Properties

        public Customer? Customer { get; set; }
        public AppUser AppUser { get; set; } = null!;
    }
}
