using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.Repositories;

namespace DepositReport.Core.Services.Contracts
{
    public interface IReportTransactionsTempService
    {
        IEnumerable<ReportTransactionsTemp> GetDuplicateCcRecords();
    }
}
