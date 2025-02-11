using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class Deposits
    {
        [Key]
        public int DepositId { get; set; }
        public int? DespositReportId { get; set; }
        public string? Mcid { get; set; }
        public DateTime? DepositDate { get; set; }
        public decimal DepositAmount { get; set; }
        public string? DepositDescription { get; set; }
        public string SettlementAccount { get; set; }
        public string? SettlementRoutingNo { get; set; }
        public string? Mid { get; set; }
        public string ProcessorMid { get; set; }
        public string? UniqueIdentifier { get; set; }
        public string? RowUid { get; set; }
        public string? SettlementId { get; set; }
        public DateTime? ReportedDate { get; set; }
        public short? DepositTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<DepositTransactions> DepositTransactions { get; set; }
    }
}
