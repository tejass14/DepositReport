using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories.Contracts
{
    public interface IMerchantRepository
    {
        IEnumerable<Merchants> GetReportableMerchants();
    }
}
