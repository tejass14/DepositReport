#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class AchtConfiguration : IEntityTypeConfiguration<Acht>
    {
        public void Configure(EntityTypeBuilder<Acht> builder)
        {
            builder.ToTable("ACHT");

            builder.HasNoKey();

            builder.HasOne(acht => acht.Files)
                .WithMany(f => f.Achts)
                .HasForeignKey(acht => acht.FileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
