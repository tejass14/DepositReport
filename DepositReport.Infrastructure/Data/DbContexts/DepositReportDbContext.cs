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
        //public virtual DbSet<ChargeBacks> ChargeBacks { get; set; }
        //public virtual DbSet<ReportDepositsAch> ReportDepositsAch { get; set; }
        //public virtual DbSet<ReportDepositsCc> ReportDepositsCc { get; set; }
        //public virtual DbSet<ReportMerchants> ReportMerchants { get; set; }
        //public virtual DbSet<ReportTxNsAch> ReportTxNsAch { get; set; }
        //public virtual DbSet<ReportTxNsCc> ReportTxNsCc { get; set; }
        //public virtual DbSet<Reversals> Reversals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepositsConfiguration());
            modelBuilder.ApplyConfiguration(new DepositTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new DepositTransactionTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
