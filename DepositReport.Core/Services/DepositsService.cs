using DepositReport.Core.Services.Contracts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;

namespace DepositReport.Core.Services
{
    public class DepositsService : IDepositsService
    {
        private readonly IDepositsRepository _depositsRepository;

        public DepositsService(IDepositsRepository depositsRepository)
        {
            _depositsRepository = depositsRepository;
        }
        public void PopulateCcSqlTransactions(string date)
        {
            var deposits = _depositsRepository.GetReportDepositsCc(date);
            foreach (var deposit in deposits)
            {
                string? parent = deposit.RowUid;
                string session = Guid.NewGuid().ToString();

                _depositsRepository.GetCcTransactions(parent, session);
            }
            //var duplicateCcTransactions = 
        }

        public void PopulateAchSqlTransactions(string date)
        {
            var deposits = _depositsRepository.GetReportDepositsCc(date);
            foreach (var deposit in deposits)
            {
                string? settId = deposit.SettlementId;
                string session = Guid.NewGuid().ToString();

               _depositsRepository.GetAchTransactions(settId, session);
            }
        }
    }
}
