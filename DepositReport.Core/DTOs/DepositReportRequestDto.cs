using System.ComponentModel.DataAnnotations;

namespace DepositReport.Core.DTOs
{
    public class DepositReportRequestDto
    {
        public string OrganizationName { get; set; }
        [Display(Name = "MCID")]
        public int Mcid { get; set; }
        public int OrganizationId { get; set; }
        public int DepositReportId { get; set; }
        [Display(Name = "CCMIDS")]
        public int CcmiDs { get; set; }
        public string ReportXml { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? TsysDate { get; set; }
        public string AchmiDs { get; set; }
        public string XmlName { get; set; }
        public string CcSummary { get; set; }
        public string AchSummary { get; set; }
        [Display(Name = "c_DepositReport")]
        public string CDepositReport { get; set; }
        // public string iFile { get; set; } 
        public string Reportxml { get; set; }
        public int XlsxReport { get; set; }
    }
}
