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
    public class CurrencyManager : ICurrencyService
    {
        private readonly ICurrencyDal _currencyDal;

        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }

        public Task CreateAsync(Currency entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Currency entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Currency>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Currency?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Currency entity)
        {
            throw new NotImplementedException();
        }
    }
}
