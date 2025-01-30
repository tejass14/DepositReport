using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class DepositReports
    {
        [Key]
        public int DepositReportID { get; set; }
        public byte DepositReportStatusTypeID { get; set; }
        public string DepositReportName { get; set; }
        public string MCID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string? ReportXml { get; set; }
    }
}
