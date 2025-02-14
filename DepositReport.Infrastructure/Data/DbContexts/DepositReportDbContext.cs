#region usings
using DepositReport.Domain.Entities;
using DepositReport.Infrastructure.Data.ModelConfigurations;
using Microsoft.EntityFrameworkCore; 
#endregion

namespace DepositReport.Infrastructure.Data.DbContexts
{
    public class DepositReportDbContext : DbContext
    {
        public DepositReportDbContext(DbContextOptions<DepositReportDbContext> options) : base(options)
        {

        }

        public virtual DbSet<DepositReports> DepositReports { get; set; }
        public virtual DbSet<Deposits> Deposits { get; set; }
        public virtual DbSet<DepositTransactions> DepositTransactions { get; set; }
        public virtual DbSet<DepositTransactionTypes> DepositTransactionTypes { get; set; }
        public virtual DbSet<Merchants> Merchants { get; set; }
        public virtual DbSet<ReportAchSettledTransactionsTemp> ReportAchSettledTransactionsTemp { get; set; }
        public virtual DbSet<ReportTransactionsTemp> ReportTransactionsTemp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepositsConfiguration());
            modelBuilder.ApplyConfiguration(new DepositTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new DepositTransactionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReportAchSettledTransactionsTempConfiguration());
            modelBuilder.ApplyConfiguration(new ReportTransactionsTempConfigurations());
            modelBuilder.ApplyConfiguration(new MerchantsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
