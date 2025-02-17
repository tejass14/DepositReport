#region usings
using DepositReport.Core.DTOs;
using DepositReport.Core.Services.Contracts;
using DepositReport.Infrastructure.Data.Repositories.Contracts; 
#endregion

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

        public void ProcessDepositsAsync(DepositRequest request)
        {
            var nextDate = GetNextWorkDate(request.Date);

            var tsysDeposits = _depositsRepository.GetTsysDepositsAsync(request.Date);

            //  var ebopDeposits = _depositsRepository.GetEBOPDepositsAsync(request.Date, nextDate);

            //   var combinedDeposits = tsysDeposits.Concat(ebopDeposits).ToList();
            /*
               foreach (var deposit in combinedDeposits)
               {
                   deposit.DepositTypeID = DetermineDepositType(deposit.DepositDescription);
               }*/
        }


        private DateTime GetNextWorkDate(DateTime date)
        {
            var nextDate = date.AddDays(1);
            return nextDate;
        }

        private string DetermineDepositType(string description)
        {
            if (description.Contains("FileID"))
            {
                return "File Deposit";
            }
            if (description.Contains("DEPOSIT"))
            {
                return "Deposit";
            }
            if (description.Contains("CHARGEBACK"))
            {
                return "Chargeback";
            }
            if (description.Contains("ADJUSTMENT"))
            {
                return "Adjustment";
            }
            return "Unknown";
        }
    }
}
