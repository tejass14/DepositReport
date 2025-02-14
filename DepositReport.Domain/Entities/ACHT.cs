namespace DepositReport.Domain.Entities
{
    public class Acht
    {
        public string BankNumber { get; set; }
        public string GroupNumberLevel1 { get; set; }
        public string AssociationNumber { get; set; }
        public string AccountNumber { get; set; }
        public string MerchantDba { get; set; }
        public string RecordType { get; set; }
        public string ProcessingDate { get; set; }
        public string AchTable { get; set; }
        public string TotalAch { get; set; }
        public string DebitCreditIndicator { get; set; }
        public long FileId { get; set; }
        public long RowId { get; set; }
        public byte ThreadId { get; set; }
        public Guid RowUid { get; set; }
        public Guid ParentUid { get; set; }
        public virtual Files Files { get; set; }
    }
}
