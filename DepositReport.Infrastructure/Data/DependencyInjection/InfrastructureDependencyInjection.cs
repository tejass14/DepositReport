#region usings
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
#endregion

namespace DepositReport.Infrastructure.Data.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DepositReportDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DepositReport")));

            services.AddDbContext<TsysDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TSYS")));

            services.AddDbContext<TsysDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MerchantActivity")));

            services.AddScoped<IDepositReportsRepository, DepositRepostsRepository>();
            services.AddScoped<IReportTransactionsTempRepository, ReportTransactionsTempRepository>();
            services.AddScoped<IReportAchSettledTransactionsTempRepository, ReportAchSettledTransactionsTempRepository>();
            services.AddScoped<IMerchantRepository, MerchantRepository>();
            services.AddScoped<IDepositsRepository, DepositsRepository>();

            return services;
        }
    }
}
