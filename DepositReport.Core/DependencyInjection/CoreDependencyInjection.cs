#region usings
using DepositReport.Core.Managers;
using DepositReport.Core.Services;
using DepositReport.Core.Services.Contracts;
using Microsoft.Extensions.DependencyInjection; 
#endregion

namespace DepositReport.Core.DependencyInjection
{
    public static class CoreDependencyInjection
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IDepositReportManager, DepositReportManager>();
            services.AddScoped<IDepositReportService, DepositReportService>();
            services.AddScoped<IReportTransactionsTempService, ReportTransactionsTempService>();
            services.AddScoped<IReportAchSettledTransactionsTempService, ReportAchSettledTransactionsTempService>();
            services.AddScoped<IMerchantService, MerchantService>();
            services.AddScoped<IDepositsService, DepositsService>();

            return services;
        }
    }
}
