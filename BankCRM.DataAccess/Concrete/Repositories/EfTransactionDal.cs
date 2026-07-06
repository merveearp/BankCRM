using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankCRM.DataAccess.Abstract;
using BankCRM.DataAccess.Concrete.Context;
using BankCRM.Entity.Entities;

namespace BankCRM.DataAccess.Concrete.Repositories
{
    public class EfTransactionDal : EfGenericRepository<Transaction>, ITransactionDal
    {
        public EfTransactionDal(BankCrmContext context) : base(context)
        {
        }
    }
}
