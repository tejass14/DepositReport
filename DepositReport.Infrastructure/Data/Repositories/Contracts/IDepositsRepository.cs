using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories.Contracts
{
    public interface IDepositsRepository
    {
        IEnumerable<Deposits> GetReportDepositsCc(string date);
        IEnumerable<Deposits> GetReportDepositsAch(string date);
        void GetCcTransactions(string? parentId, string session);
        void GetAchTransactions(string? settId, string session);
        IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords(string transactionReferenceNumber);
    }
}
