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
    public class AccountTypeManager : IAccountTypeService
    {
        private readonly IAccountTypeDal _accountTypeDal;

        public AccountTypeManager(IAccountTypeDal accountTypeDal)
        {
            _accountTypeDal = accountTypeDal;
        }

        public async Task CreateAsync(AccountType entity)
        {
            await _accountTypeDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(AccountType entity)
        {
            await _accountTypeDal.DeleteAsync(entity);
        }

        public async Task<List<AccountType>> GetAllAsync()
        {
            return await _accountTypeDal.GetAllAsync();
        }

        public async Task<AccountType?> GetByIdAsync(int id)
        {
            return await _accountTypeDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(AccountType entity)
        {
            await _accountTypeDal.UpdateAsync(entity);
        }
    }
}
