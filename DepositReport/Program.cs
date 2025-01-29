#region usings
using DepositReport.Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore; 
#endregion

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DepositReportDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DepositReport")));

builder.Services.AddDbContext<TsysDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TSYS")));

builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DepositReport}/{action=Index}/{id?}");

app.Run();
