#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class DepositsRepository : IDepositsRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;
        private readonly TsysDbContext _tsysDbContext;


        public DepositsRepository(DepositReportDbContext depositReportDbContext, TsysDbContext tsysDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
            _tsysDbContext = tsysDbContext;
        }

        public IEnumerable<Deposits> GetReportDepositsCc(string date)
        {
            return _depositReportDbContext.Deposits.FromSqlRaw("SELECT * FROM Deposits WHERE CAST(DepositDate AS DATE) = @p0 AND DepositTypeID = 3", date).AsNoTracking().ToList();
        }

        public IEnumerable<Deposits> GetReportDepositsAch(string date)
        {
            return _depositReportDbContext.Deposits.FromSqlRaw("SELECT * FROM Deposits WHERE CAST(DepositDate AS DATE) = @p0 AND DepositTypeID = 1", date).AsNoTracking().ToList();
        }

        public void GetCcTransactions(string? parentId, string session)
        {
            _depositReportDbContext.Database.ExecuteSqlRaw("EXEC StoreGetTransactionsByParentID @p0, @p1", parentId, session);
        }

        public void GetAchTransactions(string? settId, string session)
        {
            _depositReportDbContext.Database.ExecuteSqlRaw("EXEC StoreGetACHSettledTransactions @p0, @p1", settId, session);
        }

        public IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords(string transactionReferenceNumber)
        {
            return _depositReportDbContext.ReportAchSettledTransactionsTemp.FromSqlRaw("SELECT * FROM ReportTransactionsTemp WHERE TransactionReferenceNumber = @p0", transactionReferenceNumber).AsNoTracking().ToList();
        }
        public async Task<IEnumerable<Files>> GetTsysDepositsAsync(DateTime date)
        {
            return await _tsysDbContext.Files
                .FromSqlRaw("SELECT ProcessorMID, DepositDate, UniqueIdentifier, DepositAmount, DepositDescription, SettlementRoutingNo, SettlementAccount, DepositTypeID, MCID FROM TSYS WHERE DepositDate = @p0", date)
                .ToListAsync();
        }
    }
}
