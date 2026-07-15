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
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public async Task CreateAsync(Notification entity)
        {
            await _notificationDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(Notification entity)
        {
            await _notificationDal.DeleteAsync(entity);

        }

        public async Task<List<Notification>> GetAllAsync()
        {
            return await _notificationDal.GetAllAsync();
        }

        public async Task<Notification?> GetByIdAsync(int id)
        {
            return await _notificationDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Notification entity)
        {
            await _notificationDal.UpdateAsync(entity);
        }
    }
}
