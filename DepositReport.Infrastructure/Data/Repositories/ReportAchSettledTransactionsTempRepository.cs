#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore; 
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class ReportAchSettledTransactionsTempRepository : IReportAchSettledTransactionsTempRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;

        public ReportAchSettledTransactionsTempRepository(DepositReportDbContext depositReportDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
        }

        public IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords()
        {
            return _depositReportDbContext.ReportAchSettledTransactionsTemp.FromSqlRaw("SELECT * FROM ReportTransactionsTemp WHERE TransactionReferenceCode IN (SELECT TransactionReferenceCode FROM ReportTransactionsTemp GROUP BY TransactionReferenceCode HAVING COUNT(*) > 1);\r\n").AsNoTracking().ToList();
        }
    }
}
