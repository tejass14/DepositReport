#region usings
using DepositReport.Core.Services.Contracts;
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
#endregion

namespace DepositReport.Core.Services
{
    public class ReportAchSettledTransactionsTempService : IReportAchSettledTransactionsTempService
    {
        private readonly IReportAchSettledTransactionsTempRepository _reportAchSettledTransactionsTempRepository;


        public ReportAchSettledTransactionsTempService(IReportAchSettledTransactionsTempRepository reportAchSettledTransactionsTempRepository)
        {
            _reportAchSettledTransactionsTempRepository = reportAchSettledTransactionsTempRepository;
        }
        public IEnumerable<ReportAchSettledTransactionsTemp> GetDuplicateAchRecords()
        {
            return _reportAchSettledTransactionsTempRepository.GetDuplicateAchRecords();
        }
    }
}
