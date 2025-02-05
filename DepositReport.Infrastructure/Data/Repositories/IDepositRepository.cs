using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories
{
    public interface IDepositRepository
    {
        IEnumerable<DepositReports> GetDepositReports(DateTime date);
        Task<IEnumerable<Merchants>> GetReportableMerchantsAsync();
        IEnumerable<Deposits> GetReportDepositsCc();
        IEnumerable<Deposits> GetReportDepositsAch();

    }
}
