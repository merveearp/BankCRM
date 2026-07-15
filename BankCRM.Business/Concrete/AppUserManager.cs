using BankCRM.Business.Abstract;
using BankCRM.DataAccess.Abstract;
using BankCRM.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
       

        public async Task CreateAsync(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppUser>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
