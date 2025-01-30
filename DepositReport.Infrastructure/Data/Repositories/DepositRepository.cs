#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class DepositRepository : IDepositRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;

        public DepositRepository(DepositReportDbContext depositReportDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
        }
        public IEnumerable<DepositReports> GetDepositReports(DateTime date)
        {
            var depositReports = _depositReportDbContext.DepositReports.FromSqlRaw("SELECT * FROM DepositReport WHERE CAST(DepositDate AS DATE) = @p0", date).AsNoTracking().ToList();
            return depositReports;
        }
    }
}
