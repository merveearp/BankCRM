using BankCRM.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.DataAccess.Concrete.Context
{
    public class BankCrmContext :DbContext
       
    {
        public BankCrmContext(DbContextOptions options):base(options)
        {

            
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<CustomerNote> CustomerNotes { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model
        .GetEntityTypes()
        .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }

}

