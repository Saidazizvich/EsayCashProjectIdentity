using EsayCashIdentityProject_Data.Abstract;
using EsayCashIdentityProject_Data.Concreate;
using EsayCashIdentityProject_Data.EntityFremwork;
using EsayCashProjectIdentity_Business.Abstract;
using EsayCashProjectIdentity_Business.Concreate;
using EsayCashProjectIdentity_Entity.Model;
using EsayCashProjectIdentity_Pretation.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomerIdentityValidator>();

builder.Services.AddScoped<ICustomerAccountProcessDal, EntityAccountProcess>();
builder.Services.AddScoped<ICustomerAccountProcess, CustomerAccounProcessManager>();

builder.Services.AddScoped<ICustomerAccountDal, EntityCustomerAccount>();
builder.Services.AddScoped<ICustomerAccountService, CustomerAccountManager>();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
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
