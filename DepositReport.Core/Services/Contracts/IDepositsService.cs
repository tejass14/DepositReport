

using DepositReport.Core.DTOs;

namespace DepositReport.Core.Services.Contracts
{
    public interface IDepositsService
    {
        void PopulateCcSqlTransactions(string date);
        void PopulateAchSqlTransactions(string date);
        void ProcessDepositsAsync(DepositRequest request);
    }
}
