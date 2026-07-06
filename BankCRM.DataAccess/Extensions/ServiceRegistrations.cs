using BankCRM.DataAccess.Abstract;
using BankCRM.DataAccess.Concrete.Context;
using BankCRM.DataAccess.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddRepositoriesExt(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddDbContext<BankCrmContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<ITransactionDal, EfTransactionDal>();
            services.AddScoped<IRoleDal, EfRoleDal>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductCategoryDal, EfProductCategoryDal>();
            services.AddScoped<INotificationDal, EfNotificationDal>();
            services.AddScoped<ICustomerProductDal, EfCustomerProductDal>();
            services.AddScoped<ICustomerNoteDal, EfCustomerNoteDal>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();
            services.AddScoped<ICurrencyDal, EfCurrencyDal>();
            services.AddScoped<IBranchDal, EfBranchDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IActivityDal, EfActivityDal>();
            services.AddScoped<IAccountTypeDal, EfAccountTypeDal>();
            services.AddScoped<IAccountDal, EfAccountDal>();
         

        }
      
    }
}
