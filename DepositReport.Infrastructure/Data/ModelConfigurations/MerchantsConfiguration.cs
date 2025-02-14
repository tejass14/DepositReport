#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class MerchantsConfiguration : IEntityTypeConfiguration<Merchants>
    {
        public void Configure(EntityTypeBuilder<Merchants> builder)
        {
            builder.ToTable("Merchants");
            builder.HasKey(m => m.MerchantId);
        }
    }
}
