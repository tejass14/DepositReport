using Microsoft.EntityFrameworkCore;

namespace DepositReport.Infrastructure.Data.DbContexts
{
    public class MerchantActivityDbContext : DbContext
    {
        public MerchantActivityDbContext(DbContextOptions<MerchantActivityDbContext> options) : base(options)
        {

        }
    }
}
