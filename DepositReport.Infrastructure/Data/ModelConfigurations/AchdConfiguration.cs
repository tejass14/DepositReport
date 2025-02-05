using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class AchdConfiguration : IEntityTypeConfiguration<ACHD>
    {
        public void Configure(EntityTypeBuilder<ACHD> builder)
        {
            builder.ToTable("ACHD");

            builder.HasNoKey();

            builder.HasOne(achd => achd.Files)
                .WithMany(f => f.Achds)
                .HasForeignKey(achd => achd.FileID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
