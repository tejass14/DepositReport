namespace DepositReport.Domain.Entities
{
    public class ACHD
    {
        public string BankNumber { get; set; }
        public string GroupNumberLevel1 { get; set; }
        public string AssociationNumber { get; set; }
        public string AccountNumber { get; set; }
        public string MerchantDBAName { get; set; }
        public string RecordType { get; set; }
        public string RecordSequenceNumber { get; set; }
        public string ProcessingDate { get; set; }
        public string ESID { get; set; }
        public string EffectiveDate { get; set; }
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
        public long FileID { get; set; }
        public long RowID { get; set; }
        public byte ThreadID { get; set; }
        public Guid RowUID { get; set; }
        public Guid ParentUID { get; set; }
        public virtual Files Files { get; set; }

    }
}
