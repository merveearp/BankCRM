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
    public class CustomerProductManager : ICustomerProductService
    {
        private readonly ICustomerProductDal _customerProductDal;

        public CustomerProductManager(ICustomerProductDal customerProductDal)
        {
            _customerProductDal = customerProductDal;
        }

        public async Task CreateAsync(CustomerProduct entity)
        {
            await _customerProductDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(CustomerProduct entity)
        {
            await _customerProductDal.DeleteAsync(entity);
        }

        public async Task<List<CustomerProduct>> GetAllAsync()
        {
            return await _customerProductDal.GetAllAsync();
        }

        public async Task<CustomerProduct?> GetByIdAsync(int id)
        {
            return await _customerProductDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(CustomerProduct entity)
        {
           await _customerProductDal.UpdateAsync(entity);
        }
    }
}
