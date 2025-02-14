namespace DepositReport.Domain.Entities
{
    public class Achd
    {
        public string BankNumber { get; set; }
        public string GroupNumberLevel1 { get; set; }
        public string AssociationNumber { get; set; }
        public string AccountNumber { get; set; }
        public string MerchantDbaName { get; set; }
        public string RecordType { get; set; }
        public string RecordSequenceNumber { get; set; }
        public string ProcessingDate { get; set; }
        public string Esid { get; set; }
        public string EffectiveDate { get; set; }
        public string RoutingNumber { get; set; }
        public string DdaNumber { get; set; }
        public string AccountType { get; set; }
        public string AchHierarchyLevel { get; set; }
        public string AchTable { get; set; }
        public string ReferenceNumber { get; set; }
        public string TransactionTypes { get; set; }
        public string CardType { get; set; }
        public decimal Amount { get; set; }
        public string DebitCreditIndicator { get; set; }
        public string ChargebackCaseNumber { get; set; }
        public string ReserveFundingDepartment { get; set; }
        public long FileId { get; set; }
        public long RowId { get; set; }
        public byte ThreadId { get; set; }
        public Guid RowUid { get; set; }
        public Guid ParentUid { get; set; }
        public virtual Files Files { get; set; }

    }
}
