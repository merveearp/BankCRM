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
    public class EfRoleDal : EfGenericRepository<Role>, IRoleDal
    {
        public EfRoleDal(BankCrmContext context) : base(context)
        {
        }
    }
}
