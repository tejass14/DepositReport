namespace DepositReport.Core.DTOs
{
    public class DepositReportRequestDto
    {
        public string OrganizationName { get; set; }
        public int MCID { get; set; }
        public int OrganizationID { get; set; }
        public int DepositReportID { get; set; }
        public int CCMIDs { get; set; }
        public string ReportXml { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime TSYSDate { get; set; }
        public string ACHMIDs { get; set; }
        public string XmlName { get; set; }
        public string CCSummary { get; set; }
        public string ACHSummary { get; set; }
        //c_DepositReport
        //xlsxReport
    }
}
