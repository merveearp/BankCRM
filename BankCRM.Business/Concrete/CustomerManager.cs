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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task CreateAsync(Customer entity)
        {
            await _customerDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Customer entity)
        {
            await _customerDal.DeleteAsync(entity);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customerDal.GetAllAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _customerDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Customer entity)
        {
           await _customerDal.UpdateAsync(entity);
        }
    }
}
