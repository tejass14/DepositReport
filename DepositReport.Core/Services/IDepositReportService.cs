using DepositReport.Domain.Entities;

namespace DepositReport.Core.Services
{
    public interface IDepositReportService
    {
        Task<IEnumerable<Merchants>> GetReportableMerchantsAsync();
        void GenerateXml(DateTime date);
    }
}
