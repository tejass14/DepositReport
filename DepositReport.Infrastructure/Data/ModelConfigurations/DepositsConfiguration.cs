#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class DepositsConfiguration : IEntityTypeConfiguration<Deposits>
    {
        public void Configure(EntityTypeBuilder<Deposits> builder)
        {

            builder.ToTable("Deposits");

            builder.HasKey(d => d.DepositId);

            builder.HasMany(d => d.DepositTransactions)
                .WithOne(dt => dt.Deposit)
                .HasForeignKey(dt => dt.DepositId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
