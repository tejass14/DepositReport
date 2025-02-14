using DepositReport.Domain.Entities;

namespace DepositReport.Core.Services.Contracts
{
    public interface IReportAchSettledTransactionsTempService
    {
        IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords();
    }
}
