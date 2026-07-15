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
    public class TransactionManager : ITransactionService
    {
        private readonly ITransactionDal _transactionDal;

        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public async Task CreateAsync(Transaction entity)
        {
            await _transactionDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Transaction entity)
        {
            await _transactionDal.DeleteAsync(entity);
        }

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _transactionDal.GetAllAsync();
        }

        public async Task<Transaction?> GetByIdAsync(int id)
        {
            return await _transactionDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Transaction entity)
        {
            await _transactionDal.UpdateAsync(entity);
        }
    }
}
