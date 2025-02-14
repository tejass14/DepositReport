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
            builder.HasKey(f => f.FileId);

            // Relationships
            builder.HasOne(f => f.FileTypes)
                .WithMany(ft => ft.Files)
                .HasForeignKey(f => f.FileTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Achds)
                .WithOne()
                .HasForeignKey(a => a.FileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Achts)
                .WithOne()
                .HasForeignKey(a => a.FileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
