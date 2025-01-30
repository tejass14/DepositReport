using DepositReport.Domain.Entities;

namespace DepositReport.Core.Services
{
    public interface IDepositReportService
    {
        Task<IEnumerable<Merchants>> GetReportableMerchantsAsync();
    }
}
