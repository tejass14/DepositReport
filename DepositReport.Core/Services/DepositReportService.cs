#region usings
using DepositReport.Core.Services.Contracts;
using DepositReport.Infrastructure.Data.Repositories.Contracts; 
#endregion

namespace DepositReport.Core.Services
{
    public class DepositReportService : IDepositReportService
    {
        private readonly IDepositReportsRepository _depositReportRepository;

        public DepositReportService(IDepositReportsRepository depositReportRepository)
        {
            _depositReportRepository = depositReportRepository;
        }

        public void GenerateXml(DateTime date)
        {
            var depositReports = _depositReportRepository.GetDepositReports(date);
            foreach (var depositReport in depositReports)
            {

            }
        }
    }
}
