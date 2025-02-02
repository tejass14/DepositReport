﻿using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class Deposits
    {
        [Key]
        public int DepositID { get; set; }
        public int? DespositReportID { get; set; }
        public string? MCID { get; set; }
        public DateTime? DepositDate { get; set; }
        public decimal DepositAmount { get; set; }
        public string? DepositDescription { get; set; }
        public string SettlementAccount { get; set; }
        public string? SettlementRoutingNo { get; set; }
        public string? MID { get; set; }
        public string ProcessorMID { get; set; }
        public string? UniqueIdentifier { get; set; }
        public string? RowUID { get; set; }
        public string? settlement_id { get; set; }
        public DateTime? ReportedDate { get; set; }
        public short? DepositTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<DepositTransactions> DepositTransactions { get; set; }
    }
}
