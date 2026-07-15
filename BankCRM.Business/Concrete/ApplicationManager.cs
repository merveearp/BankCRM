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
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationDal _applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public async Task CreateAsync(Application entity)
        {
            await _applicationDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Application entity)
        {
            await _applicationDal.DeleteAsync(entity);
        }

        public async Task<List<Application>> GetAllAsync()
        {
            return await _applicationDal.GetAllAsync();
        }

        public async Task<Application?> GetByIdAsync(int id)
        {
            return await _applicationDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Application entity)
        {
            await _applicationDal.UpdateAsync(entity);
        }
    }
}
