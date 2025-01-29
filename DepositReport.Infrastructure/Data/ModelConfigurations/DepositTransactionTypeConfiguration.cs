#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class DepositTransactionTypeConfiguration : IEntityTypeConfiguration<DepositTransactionTypes>
    {
        public void Configure(EntityTypeBuilder<DepositTransactionTypes> builder)
        {
            builder.ToTable("DepositTransactionTypes");

            builder.HasKey(dtt => dtt.DepositTransactionTypeID);
        }
    }
}
