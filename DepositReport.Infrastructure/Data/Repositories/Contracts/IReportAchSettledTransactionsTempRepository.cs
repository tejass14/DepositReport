using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories.Contracts
{
    public interface IReportAchSettledTransactionsTempRepository
    {
        IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords();
    }
}
