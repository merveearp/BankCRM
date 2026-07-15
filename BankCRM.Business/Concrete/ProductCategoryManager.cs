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
    public class ProductCategoryManager : IProductCategoryService
    {
        private readonly IProductCategoryDal _productCategoryDal;

        public ProductCategoryManager(IProductCategoryDal productCategoryDal)
        {
            _productCategoryDal = productCategoryDal;
        }

        public async Task CreateAsync(ProductCategory entity)
        {
            await _productCategoryDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(ProductCategory entity)
        {
            await _productCategoryDal.DeleteAsync(entity);
        }

        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await _productCategoryDal.GetAllAsync();
        }

        public async Task<ProductCategory?> GetByIdAsync(int id)
        {
            return await _productCategoryDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(ProductCategory entity)
        {
            await _productCategoryDal.UpdateAsync(entity);
        }
    }
}
