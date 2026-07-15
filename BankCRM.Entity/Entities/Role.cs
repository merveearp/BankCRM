using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class AppRole :BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
     


        //Navigation
        public ICollection<AppUser> AppUsers { get; set; } 
    }
}
