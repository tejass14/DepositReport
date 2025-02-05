using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.Repositories;
namespace DepositReport.Core.Services
{
    public class DepositReportService: IDepositReportService
    {
        private readonly IDepositRepository _depositRepository;

        public DepositReportService(IDepositRepository depositRepository)
        {
            _depositRepository = depositRepository;
        }

        public async Task<IEnumerable<Merchants>> GetReportableMerchantsAsync()
        {
            return await _depositRepository.GetReportableMerchantsAsync();
        }

        public void GenerateXml(DateTime date)
        {
            var depositReports = _depositRepository.GetDepositReports(date);
            foreach (var depositReport in depositReports)
            {
                
            }
        }
    }
}
