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
    public class CustomerNoteManager : ICustomerNoteService
    {
        private readonly ICustomerNoteDal _customerNoteDal;

        public CustomerNoteManager(ICustomerNoteDal customerNoteDal)
        {
            _customerNoteDal = customerNoteDal;
        }

        public async Task CreateAsync(CustomerNote entity)
        {
            await _customerNoteDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(CustomerNote entity)
        {
            await _customerNoteDal.DeleteAsync(entity);
        }

        public async Task<List<CustomerNote>> GetAllAsync()
        {
             return await _customerNoteDal.GetAllAsync();
        }

        public async Task<CustomerNote?> GetByIdAsync(int id)
        {
            return await _customerNoteDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(CustomerNote entity)
        {
            await _customerNoteDal.UpdateAsync(entity);
        }
    }
}
