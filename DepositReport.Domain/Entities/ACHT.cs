namespace DepositReport.Domain.Entities
{
    public class ACHT
    {
        public string BankNumber { get; set; }
        public string GroupNumberLevel1 { get; set; }
        public string AssociationNumber { get; set; }
        public string AccountNumber { get; set; }
        public string MerchantDBA { get; set; }
        public string RecordType { get; set; }
        public string ProcessingDate { get; set; }
        public string ACHTable { get; set; }
        public string TotalACH { get; set; }
        public string DebitCreditIndicator { get; set; }
        public long FileID { get; set; }
        public long RowID { get; set; }
        public byte ThreadID { get; set; }
        public Guid RowUID { get; set; }
        public Guid ParentUID { get; set; }
        public virtual Files Files { get; set; }
    }
}
