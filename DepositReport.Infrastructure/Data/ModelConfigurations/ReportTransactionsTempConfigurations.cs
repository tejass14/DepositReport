#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    internal class ReportTransactionsTempConfigurations : IEntityTypeConfiguration<ReportTransactionsTemp>
    {
        public void Configure(EntityTypeBuilder<ReportTransactionsTemp> builder)
        {
            builder.ToTable("ReportTransactionsTemp");
            builder.HasNoKey();
        }
    }
}
