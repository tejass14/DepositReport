using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class AchdConfiguration : IEntityTypeConfiguration<Achd>
    {
        public void Configure(EntityTypeBuilder<Achd> builder)
        {
            builder.ToTable("ACHD");

            builder.HasNoKey();

            builder.HasOne(achd => achd.Files)
                .WithMany(f => f.Achds)
                .HasForeignKey(achd => achd.FileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
