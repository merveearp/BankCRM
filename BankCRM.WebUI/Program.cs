
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
    ////şifre kuralları 
    //options.Password.RequiredLength = 6;
    //options.Password.RequireUppercase = true;
    //options.Password.RequireLowercase = true;
    //options.Password.RequireDigit = true;
    //options.Password.RequireNonAlphanumeric = true;

    //kullanıcı ayarları
    options.User.RequireUniqueEmail = true;

    //kilitleme ayarları
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.AllowedForNewUsers = true;
})
.AddEntityFrameworkStores<BankCrmContext>()
.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Auth/Login";

    options.ExpireTimeSpan = TimeSpan.FromHours(8);
    options.Cookie.Name = "BankCRM.Auth";
    options.SlidingExpiration = true;


});
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
