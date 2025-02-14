using DepositReport.Domain.Entities;

namespace DepositReport.Core.Services.Contracts
{
    public interface IMerchantService
    {
        IEnumerable<Merchants> GetReportableMerchants();
    }
}
