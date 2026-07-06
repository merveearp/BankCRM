using BankCRM.DataAccess.Concrete.Context;
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


         

        }
      
    }
}
