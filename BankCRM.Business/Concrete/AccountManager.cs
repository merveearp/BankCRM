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
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public async Task CreateAsync(Account entity)
        {
           await _accountDal.CreateAsync(entity);   
        }

        public async Task DeleteAsync(Account entity)
        {
            await _accountDal.DeleteAsync(entity);
        }

        public async Task<List<Account>> GetAllAsync()
        {
           return await _accountDal.GetAllAsync();
        }

        public async Task<Account?> GetByIdAsync(int id)
        {
            return await _accountDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Account entity)
        {
            await _accountDal.UpdateAsync(entity);
        }
    }
}
