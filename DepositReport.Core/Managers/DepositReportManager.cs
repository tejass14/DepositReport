#region usings
using DepositReport.Core.Services;
using DepositReport.Core.Services.Contracts;
using System.Globalization;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using DepositReport.Infrastructure.Data.Repositories;
#endregion

namespace DepositReport.Core.Managers
{
    public class DepositReportManager : IDepositReportManager
    {
        private readonly IDepositReportService _depositReportService;
        private readonly IDepositsService _depositsService;
        private readonly IMerchantService _merchantService;
        private readonly IReportTransactionsTempService _reportTransactionsTempService;
        private readonly IReportAchSettledTransactionsTempService _reportAchSettledTransactionsTempService;

        public DepositReportManager(IDepositReportService depositReportService, 
            IDepositsService depositsService, IMerchantService merchantService,
            IReportTransactionsTempService reportTransactionsTempService,
            IReportAchSettledTransactionsTempService reportAchSettledTransactionsTempService)
        {
            _depositReportService = depositReportService;
            _depositsService = depositsService;
            _merchantService = merchantService;
            _reportTransactionsTempService = reportTransactionsTempService;
            _reportAchSettledTransactionsTempService = reportAchSettledTransactionsTempService;
        }

        public void GenerateCaller()
        {
            DateTime previousWorkday = GetPreviousWorkDate(DateTime.Now);
            string date = previousWorkday.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

            var merchantsList = _merchantService.GetReportableMerchants();

            //_depositsService.PopulateCcSqlTransactions(date);
            var duplicateCcRecords = _reportTransactionsTempService.GetDuplicateCcRecords();

            //_depositsService.PopulateAchSqlTransactions(date);
            var duplicateAchRecords = _reportAchSettledTransactionsTempService.GetDuplicateAchRecords();
        }

        private static DateTime GetPreviousWorkDate(DateTime date)
        {
            do
            {
                date = date.AddDays(-1);
            }
            while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

            return date;
        }
    }
}
