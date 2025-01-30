using DepositReport.Domain.Entities;

namespace DepositReport.Infrastructure.Data.Repositories
{
    public interface IDepositRepository
    {
        public IEnumerable<DepositReports> GetDepositReports(DateTime date);
    }
}
