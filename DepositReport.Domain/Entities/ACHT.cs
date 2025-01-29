namespace DepositReport.Domain.Entities
{
    public class ACHT
    {
        public int BankNumber { get; set; }
        public int GroupNumberLevel1 { get; set; }
        public int AssociationNumber { get; set; }
        public int AccountNumber { get; set; }
        public string MerchantDBA { get; set; }
        public string RecordType { get; set; }
        public DateTime ProcessingDate { get; set; }
        public string ACHTable { get; set; }
        public decimal TotalACH { get; set; }
        public string DebitCreditIndicator { get; set; }
        public int FileID { get; set; }
        public int RowID { get; set; }
        public int ThreadID { get; set; }
        public Guid RowUID { get; set; }
        public Guid ParentUID { get; set; }
        public virtual Files Files { get; set; }
    }
}
