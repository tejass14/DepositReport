#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.ModelConfigurations;
using Microsoft.EntityFrameworkCore; 
#endregion

namespace DepositReport.Infrastructure.Data.DbContexts
{
    public class TsysDbContext : DbContext
    {
        public TsysDbContext(DbContextOptions<TsysDbContext> options) : base(options)
        {

        }
        public virtual DbSet<FileTypes> FileTypes { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<ACHD> AchDs { get; set; }
        public virtual DbSet<ACHT> AchTs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FileTypesConfiguration());
            modelBuilder.ApplyConfiguration(new FileConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
