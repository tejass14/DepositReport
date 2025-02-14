using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories.Contracts
{
    public interface IReportTransactionsTempRepository
    {
        IEnumerable<ReportTransactionsTemp> GetDuplicateCcRecords();
    }
}
