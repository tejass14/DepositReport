#region usings
using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
#endregion

namespace DepositReport.Infrastructure.Data.ModelConfigurations
{
    public class FileTypesConfiguration : IEntityTypeConfiguration<FileTypes>
    {
        public void Configure(EntityTypeBuilder<FileTypes> builder)
        {
            builder.ToTable("FileTypes");
            builder.HasKey(ft => ft.FileTypeId);

            // Relationships
            builder.HasMany(ft => ft.Files)
                .WithOne(f => f.FileTypes)
                .HasForeignKey(f => f.FileTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
