namespace DepositReport.Domain.Entities
{
    public class ReportACHSettledTransactionsTemp
    {
        public string ABA { get; set; }
        public string AccountNumberMasked { get; set; }
        public string AccountReferenceCode { get; set; }
        public long? ACHProcessorExportFileID { get; set; }
        public string ACHProcessorExportFileName { get; set; }
        public string ACHProcessorExportFileStatusName { get; set; }
        public string CaptureSourceTypeName { get; set; }
        public int? CaptureTrackingNumberID { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerReferenceCode { get; set; }
        public string DebitCreditTypeName { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LoginName { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public int? OrganizationID { get; set; }
        public string PayeeCode { get; set; }
        public string PayeeName { get; set; }
        public DateTime? SettlementDate { get; set; }
        public byte? SettlementTypeID { get; set; }
        public decimal? Amount { get; set; }
        public string TraceNumber { get; set; }
        public int? TransactionCancelledTypeID { get; set; }
        public string TransactionCancelledTypeName { get; set; }
        public string TransactionReferenceCode { get; set; }
        public string TransactionStatusTypeName { get; set; }
        public string UserDefinedBatchName { get; set; }
        public string UserDefinedFieldOne { get; set; }
        public string UserDefinedFieldTwo { get; set; }
        public string UserFullName { get; set; }
        public long? ValidationBatchID { get; set; }
        public string ValidationBatchName { get; set; }
        public string EbopTransactionStatus { get; set; }
        public string SessionID { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
