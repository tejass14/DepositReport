#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class ReportTransactionsTempRepository : IReportTransactionsTempRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;

        public ReportTransactionsTempRepository(DepositReportDbContext depositReportDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
        }

        public IEnumerable<ReportTransactionsTemp> GetDuplicateCcRecords()
        {
            return _depositReportDbContext.ReportTransactionsTemp.FromSqlRaw("SELECT * FROM ReportTransactionsTemp WHERE TransactionReferenceCode IN (SELECT TransactionReferenceCode FROM ReportTransactionsTemp GROUP BY TransactionReferenceCode HAVING COUNT(*) > 1);\r\n").AsNoTracking().ToList();
        }
    }
}
