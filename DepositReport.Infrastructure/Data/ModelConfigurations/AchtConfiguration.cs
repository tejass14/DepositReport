#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class AchtConfiguration : IEntityTypeConfiguration<ACHT>
    {
        public void Configure(EntityTypeBuilder<ACHT> builder)
        {
            builder.ToTable("ACHT");

            builder.HasNoKey();

            builder.HasOne(acht => acht.Files)
                .WithMany(f => f.Achts)
                .HasForeignKey(acht => acht.FileID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
