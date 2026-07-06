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
    public class EfCurrencyDal : EfGenericRepository<Currency>, ICurrencyDal
    {
        public EfCurrencyDal(BankCrmContext context) : base(context)
        {
        }
    }
}
