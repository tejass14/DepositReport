#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class ReportAchSettledTransactionsTempConfiguration : IEntityTypeConfiguration<ReportAchSettledTransactionsTemp>
    {
        public void Configure(EntityTypeBuilder<ReportAchSettledTransactionsTemp> builder)
        {
            builder.ToTable("ReportACHSettledTransactionsTemp");
            builder.HasNoKey();
        }
    }
}
