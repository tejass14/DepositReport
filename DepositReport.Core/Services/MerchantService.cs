#region usings
using DepositReport.Core.Services.Contracts;
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
#endregion
namespace DepositReport.Core.Services
{
    public class MerchantService : IMerchantService
    {
        private readonly IMerchantRepository _merchantRepository;

        public MerchantService(IMerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }
        public IEnumerable<Merchants> GetReportableMerchants()
        {
            return _merchantRepository.GetReportableMerchants();
        }
    }
}
