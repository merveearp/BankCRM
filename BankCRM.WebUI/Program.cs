
using BankCRM.DataAccess.Concrete.Context;
using BankCRM.DataAccess.Extensions;
using BankCRM.Entity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRepositoriesExt(builder.Configuration);

builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = false;

    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<BankCrmContext>()
.AddDefaultTokenProviders();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
