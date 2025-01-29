namespace DepositReport.Domain.Entities
{
    public class DepositTransactions
    {
        public int DepositTransactionID { get; set; }
        public int DepositID { get; set; }
        public int DepositTransactionTypeID { get; set; }
        public int? TransactionID { get; set; }
        public string TransactionReferenceCode { get; set; }
        public string TransactionStatusTypeName { get; set; }
        public string TransactionCancelledTypeName { get; set; }
        public int? CaptureTrackingNumberID { get; set; }
        public string CaptureTrackingNumber { get; set; }
        public string CaptureSourceTypeName { get; set; }
        public string UserDefinedFieldOne { get; set; }
        public string UserDefinedFieldTwo { get; set; }
        public string ConfirmationNumber { get; set; }
        public string LoginName { get; set; }
        public string UserFullName { get; set; }
        public int? OrganizationID { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerReferenceCode { get; set; }
        public string AccountReferenceCode { get; set; }
        public string CardNumberMasked { get; set; }
        public string CardNumberWithType { get; set; }
        public string ABA { get; set; }
        public string AccountNumberMasked { get; set; }
        public DateTime? SettlementDate { get; set; }
        public decimal Amount { get; set; }
        public int? ValidationBatchID { get; set; }
        public string DebitCreditTypeName { get; set; }
        public int? TransactionCancelledTypeID { get; set; }
        public int? ACHProcessorExportFileID { get; set; }
        public int? SettlementTypeID { get; set; }
        public string ValidationBatchName { get; set; }
        public string UserDefinedBatchName { get; set; }
        public string UniqueIdentifier { get; set; }
        public string PVTransactionDataLink { get; set; }
        public DateTime? ReportedDate { get; set; }
        public bool IsEarlyReturn { get; set; }
        public bool IsLateReturn { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string ACHProcessorExportFileName { get; set; }
        public string ACHProcessorExportFileStatusName { get; set; }
        public string AuthorizationCode { get; set; }
        public string AuthorizationNumber { get; set; }
        public string CardExpDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateReported { get; set; }
        public string ForwardFileName { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public string OriginalTraceNumber { get; set; }
        public int? OriginalSubmittedTransactionID { get; set; }
        public string OriginalSubmittedTransactionRefCode { get; set; }
        public Guid ParentUID { get; set; }
        public string PayeeCode { get; set; }
        public string PayeeName { get; set; }
        public string ProcessorMID { get; set; }
        public int? PVGatewayAuditID { get; set; }
        public int? PVGatewayRequestTypeID { get; set; }
        public int? SettlementID { get; set; }
        public string Status { get; set; }
        public string TraceNumber { get; set; }
        public string TransactionType { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Deposits Deposit { get; set; }
        public DepositTransactionTypes DepositTransactionType { get; set; }
    }

}
