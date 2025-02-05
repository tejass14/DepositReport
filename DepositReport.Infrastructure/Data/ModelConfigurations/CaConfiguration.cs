#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion
namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class CaConfiguration : IEntityTypeConfiguration<Ca>
    {
        public void Configure(EntityTypeBuilder<Ca> builder)
        {
            builder.ToTable("CA");

            builder.HasNoKey();

            builder.HasOne(ca => ca.Files)
                .WithMany(f => f.Ca)
                .HasForeignKey(ca => ca.FileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
