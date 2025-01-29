#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class DepositTransactionConfiguration : IEntityTypeConfiguration<DepositTransactions>
    {
        public void Configure(EntityTypeBuilder<DepositTransactions> builder)
        {
            builder.ToTable("DepositTransactions");

            builder.HasKey(dt => dt.DepositTransactionID);

            builder.HasOne(dt => dt.Deposit)
                .WithMany(d => d.DepositTransactions)
                .HasForeignKey(dt => dt.DepositID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(dt => dt.DepositTransactionType)
                .WithMany(dtt => dtt.DepositTransactions)
                .HasForeignKey(dt => dt.DepositTransactionTypeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
