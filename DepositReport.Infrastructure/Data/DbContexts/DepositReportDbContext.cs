using DepositReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DepositReport.Infrastructure.Data.DbContexts
{
    public class DepositReportDbContext : DbContext
    {
        public DepositReportDbContext(DbContextOptions<DepositReportDbContext> options) : base(options)
        {

        }

        public virtual DbSet<DepositReports> DepositReports { get; set; }
        public virtual DbSet<ChargeBacks> ChargeBacks { get; set; }
        public virtual DbSet<ReportDepositsAch> ReportDepositsAch { get; set; }
        public virtual DbSet<ReportDepositsCc> ReportDepositsCc { get; set; }
        public virtual DbSet<ReportMerchants> ReportMerchants { get; set; }
        public virtual DbSet<ReportTxNsAch> ReportTxNsAch { get; set; }
        public virtual DbSet<ReportTxNsCc> ReportTxNsCc { get; set; }
        public virtual DbSet<Reversals> Reversals { get; set; }
    }
}
