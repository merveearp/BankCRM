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
    public class ActivityManager : IActivityService
    {
        private readonly IActivityDal _activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public async Task CreateAsync(Activity entity)
        {
            await _activityDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Activity entity)
        {
            await _activityDal.DeleteAsync(entity); 
        }

        public async Task<List<Activity>> GetAllAsync()
        {
            return await _activityDal.GetAllAsync();
        }

        public async Task<Activity?> GetByIdAsync(int id)
        {
           return await _activityDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Activity entity)
        {
           await _activityDal.UpdateAsync(entity);
        }
    }
}
