using BankCRM.Entity.Entities.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class AppRole :IdentityRole<int>
    {
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
