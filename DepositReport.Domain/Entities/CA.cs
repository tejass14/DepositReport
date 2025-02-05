namespace DepositReport.Domain.Entities
{
    public class Ca
    {
        public int Id { get; set; } // Primary Key
        public string CaseNumber { get; set; }
        public string FullReasonCode { get; set; }
        public string VisaRDRIndicator { get; set; }
        public string ItemType { get; set; }
        public string MerchantNumber { get; set; }
        public string CaseType { get; set; }
        public string ResolutionTo { get; set; }
        public string DebitCredit { get; set; }
        public string TranCode { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
        public string BINICA { get; set; }
        public decimal CaseAmount { get; set; }
        public string RecordType { get; set; }
        public string CardBrand { get; set; }
        public DateTime? DateResolved { get; set; }
        public string AcquirerReferenceNumber { get; set; }
        public string OriginalReferenceNumber { get; set; }
        public string ForeignDomestic { get; set; }
        public string MCC { get; set; }
        public string AuthCode { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateLoaded { get; set; }
        public string CardholderAccountNumber { get; set; }
        public DateTime? DateSecondRequest { get; set; }
        public string AccountNumberPrefix { get; set; }
        public string AccountNumberSuffix { get; set; }
        public string DBAName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string GroupName { get; set; }
        public string Association { get; set; }
        public DateTime? DateWarehouse { get; set; }
        public string TransID { get; set; }
        public decimal? MerchAmount { get; set; }
        public string FamilyID { get; set; }
        public string ChargebackReferenceNumber { get; set; }
        public string MCOMMClaimID { get; set; }
        public string VROLCaseNumber { get; set; }

        public int FileId { get; set; }
        public Files Files { get; set; } 

        public string RowID { get; set; }
        public string ThreadID { get; set; }
        public string RowUID { get; set; }
        public string ParentUID { get; set; }
    }

}
