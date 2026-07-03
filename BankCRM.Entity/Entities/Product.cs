using BankCRM.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Entity.Entities
{
    public class Product:BaseEntity
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
     


        // Navigation Property

        public ProductCategory ProductCategory { get; set; } = null!;
        public IList<CustomerProduct> CustomerProducts { get; set; }

    }
}
