using DepositReport.Core.Services.Contracts;
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.Repositories;
using DepositReport.Infrastructure.Data.Repositories.Contracts;

namespace DepositReport.Core.Services
{
    public class ReportTransactionsTempService : IReportTransactionsTempService
    {
        private readonly IReportTransactionsTempRepository _reportTransactionsTempRepository;

        public ReportTransactionsTempService(IReportTransactionsTempRepository reportTransactionsTempRepository)
        {
            _reportTransactionsTempRepository = reportTransactionsTempRepository;
        }
        public IEnumerable<ReportTransactionsTemp> GetDuplicateCcRecords()
        {
            return _reportTransactionsTempRepository.GetDuplicateCcRecords();
        }
    }
}
