namespace DepositReport.Domain.Entities
{
    public class ACHD
    {
        public int BankNumber { get; set; }
        public int GroupNumberLevel1 { get; set; }
        public int AssociationNumber { get; set; }
        public int AccountNumber { get; set; }
        public string MerchantDBAName { get; set; }
        public string RecordType { get; set; }
        public int RecordSequenceNumber { get; set; }
        public DateTime ProcessingDate { get; set; }
        public int ESID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string RoutingNumber { get; set; }
        public string DDANumber { get; set; }
        public string AccountType { get; set; }
        public string ACHHierarchyLevel { get; set; }
        public string ACHTable { get; set; }
        public string ReferenceNumber { get; set; }
        public string TransactionTypes { get; set; }
        public string CardType { get; set; }
        public decimal Amount { get; set; }
        public string DebitCreditIndicator { get; set; }
        public string ChargebackCaseNumber { get; set; }
        public string ReserveFundingDepartment { get; set; }
        public int FileID { get; set; }
        public int RowID { get; set; }
        public int ThreadID { get; set; }
        public Guid RowUID { get; set; }
        public Guid ParentUID { get; set; }
        public virtual Files Files { get; set; }

    }
}
