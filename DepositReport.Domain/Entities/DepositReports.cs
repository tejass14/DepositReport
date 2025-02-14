using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class DepositReports
    {
        [Key]
        public int DepositReportId { get; set; }
        public byte DepositReportStatusTypeId { get; set; }
        public string DepositReportName { get; set; }
        public string Mcid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string? ReportXml { get; set; }
    }
}
