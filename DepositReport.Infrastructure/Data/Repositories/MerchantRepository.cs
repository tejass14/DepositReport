#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.DbContexts;
using DepositReport.Infrastructure.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
#endregion

namespace DepositReport.Infrastructure.Data.Repositories
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly DepositReportDbContext _depositReportDbContext;

        public MerchantRepository(DepositReportDbContext depositReportDbContext)
        {
            _depositReportDbContext = depositReportDbContext;
        }
        public IEnumerable<Merchants> GetReportableMerchants()
        {
            return _depositReportDbContext.Merchants.FromSqlRaw("SELECT * FROM Merchants WHERE Reportable = 1").AsNoTracking().ToList();
        }
    }
}
