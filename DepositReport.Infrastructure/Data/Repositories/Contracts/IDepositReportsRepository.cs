using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories.Contracts
{
    public interface IDepositReportsRepository
    {
        IEnumerable<DepositReports> GetDepositReports(DateTime date);
    }
}
