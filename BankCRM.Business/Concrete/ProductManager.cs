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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task CreateAsync(Product entity)
        {
            await _productDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Product entity)
        {
           await _productDal.DeleteAsync(entity);
        }

        public async Task<List<Product>> GetAllAsync()
        {
           return await _productDal.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _productDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Product entity)
        {
            await _productDal.UpdateAsync(entity);
        }
    }
}
