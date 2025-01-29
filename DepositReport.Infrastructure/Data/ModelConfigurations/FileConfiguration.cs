#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class FileConfiguration : IEntityTypeConfiguration<Files>
    {
        public void Configure(EntityTypeBuilder<Files> builder)
        {
            builder.ToTable("Files");
            builder.HasKey(f => f.FileID);

            // Relationships
            builder.HasOne(f => f.FileTypes)
                .WithMany(ft => ft.Files)
                .HasForeignKey(f => f.FileTypeID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Achds)
                .WithOne()
                .HasForeignKey(a => a.FileID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Achts)
                .WithOne()
                .HasForeignKey(a => a.FileID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
