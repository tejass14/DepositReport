#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class DepositRepostsRepository : IDepositReportsRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;

        public DepositRepostsRepository(DepositReportDbContext depositReportDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
        }
        public IEnumerable<DepositReports> GetDepositReports(DateTime date)
        {
            return _depositReportDbContext.DepositReports.FromSqlRaw("SELECT * FROM DepositReport WHERE CAST(DepositDate AS DATE) = @p0", date).AsNoTracking().ToList();
        }
    }
}
