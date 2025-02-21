﻿using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class Merchants
    {
        public int MerchantId { get; set; }
        public string AccountName { get; set; }
        public int? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public string? MerchantCode { get; set; }
        public string? MID { get; set; }
        public string? ProcessorMID { get; set; }
        public string? SettlementAccount { get; set; }
        public string? SettlementRoutingNo { get; set; }
        public string? SourceSystemIdentifier { get; set; }
        public int? MCID { get; set; }
        public string? MIDType { get; set; }
        public string? Category { get; set; }
        public string? DataSource { get; set; }
        public DateTime? LastDepositDate { get; set; }
        public int? Reportable { get; set; }
    }
}
