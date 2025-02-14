using DepositReport.Domain.Entities;

namespace DepositReport.Core.Services.Contracts
{
    public interface IDepositReportService
    {
        void GenerateXml(DateTime date);
    }
}
