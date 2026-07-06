using BankCRM.DataAccess.Abstract;
using BankCRM.DataAccess.Concrete.Context;
using BankCRM.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.DataAccess.Concrete.Repositories
{
    public class EfProductCategoryDal : EfGenericRepository<ProductCategory>, IProductCategoryDal
    {
        public EfProductCategoryDal(BankCrmContext context) : base(context)
        {
        }
    }
}
