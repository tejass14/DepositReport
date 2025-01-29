namespace DepositReport.Domain.Entities
{
    public class DepositReports
    {
        public int DepositReportID { get; set; }
        public int DepositReportStatusTypeID { get; set; }
        public string DepositReportName { get; set; }
        public int MCID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string? ReportXml { get; set; }
    }
}
