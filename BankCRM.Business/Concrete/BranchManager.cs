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
    public class BranchManager : IBranchService
    {
        private readonly IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public Task CreateAsync(Branch entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Branch entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Branch>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Branch?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Branch entity)
        {
            throw new NotImplementedException();
        }
    }
}
